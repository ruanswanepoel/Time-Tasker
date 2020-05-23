
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeTasker {

	/// <summary>
	/// Represents a list of type <see cref="Task"/>.
	/// </summary>
	public class TaskList {

		public enum SortOrders {
			Alphabetical,
			DateCreated,
			DueDate,
			Priority
		}

		/// <summary>
		/// Invoked when the underlying Tasklist changes.
		/// </summary>
		public event TaskListChangedEventHandler Changed;


		/// <summary>
		/// Gets the name if the <see cref="TaskList"/>.
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// Gets the underlying <see cref="Task"/> list of the <see cref="TaskList"/>
		/// </summary>
		public List<Task> Tasks { get; private set; }

		public SortOrders SortOrder { get; private set; }


		public TaskList(JToken token) {

			Name = token["Name"].ToString();
			Tasks = new List<Task>();
			SortOrder = SortOrdersExtentionMethods.FromString(token["SortOrder"].ToString());

			foreach (JToken taskToken in token["Tasks"])
				Tasks.Add(new Task(taskToken));

			Sort();

		}

		public TaskList(string name)
			: this(name, new List<Task>()) { }
		public TaskList(string name, List<Task> tasks)
			: this(name, tasks, SortOrders.Alphabetical) { }

		public TaskList(string name, List<Task> tasks, SortOrders sortOrder) {

			Name = name;
			Tasks = tasks;
			SortOrder = sortOrder;

			Sort();

		}

		/// <summary>
		/// Adds a <see cref="Task"/> to the end of the <see cref="TaskList"/>
		/// </summary>
		/// <param name="task"></param>
		public void AddTask(Task task) {

			Tasks.Add(task);

			Changed?.Invoke(this, new TaskListChangedEventArgs(task, TaskListChangedEventArgs.ChangeTypes.TaskAdded));

		}

		/// <summary>
		/// Removes the given <see cref="Task"/> from the <see cref="TaskList"/>
		/// </summary>
		/// <param name="task"></param>
		public void RemoveTask(Task task) {

			Tasks.Remove(task);

			Changed?.Invoke(this, new TaskListChangedEventArgs(task, TaskListChangedEventArgs.ChangeTypes.TaskRemoved));

		}

		public void Sort() {

			switch (SortOrder) {
				case SortOrders.Alphabetical: {
					SortByAlphabetical();
					break;
				}
				case SortOrders.DateCreated: {
					SortByDateCreated();
					break;
				}
				case SortOrders.DueDate: {
					SortByDueDate();
					break;
				}
				case SortOrders.Priority: {
					SortByPriority();
					break;
				}
			}

		}

		/// <summary>
		/// Reorders the list according to the next item in the <see cref="TaskList"/>.<see cref="SortOrders"/>
		/// </summary>
		public void DoNextSortOrder() {

			SortOrder = SortOrder.NextItem();
			Sort();

		}

		private void SortByAlphabetical() {

			Tasks = Tasks.OrderBy(x => x.Message).ToList();
			SortOrder = SortOrders.Alphabetical;

			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByDateCreated() {

			Tasks = Tasks.OrderBy(x => x.DateCreated).ToList();
			SortOrder = SortOrders.DateCreated;

			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByDueDate() {

			Tasks = Tasks.OrderBy(x => x.DueDate).ToList();
			SortOrder = SortOrders.DueDate;

			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByPriority() {

			Tasks = Tasks.OrderBy(x => x.Priority).ToList();
			SortOrder = SortOrders.Priority;

			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}
		
	}

	public static class SortOrdersExtentionMethods {

		public static string ToFriendlyString(this TaskList.SortOrders obj) {

			string val = obj.ToString();
			string result = "";

			for (int i = 0; i < val.Length; i++) {
				if (i != 0 && Char.IsUpper(val[i]))
					result += " ";
				result += val[i];
			}

			return result;

		}

		public static TaskList.SortOrders FromString(string str) {

			return (TaskList.SortOrders)Enum.Parse(typeof(TaskList.SortOrders), str);

		}

		public static TaskList.SortOrders NextItem(this TaskList.SortOrders obj) {

			TaskList.SortOrders sortOrder = TaskList.SortOrders.Alphabetical;

			switch (obj) {
				case TaskList.SortOrders.Alphabetical: {
					sortOrder = TaskList.SortOrders.DateCreated;
					break;
				}
				case TaskList.SortOrders.DateCreated: {
					sortOrder = TaskList.SortOrders.DueDate;
					break;
				}
				case TaskList.SortOrders.DueDate: {
					sortOrder = TaskList.SortOrders.Priority;
					break;
				}
				case TaskList.SortOrders.Priority: {
					sortOrder = TaskList.SortOrders.Alphabetical;
					break;
				}
			}

			return sortOrder;

		}

	}

}
