
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


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
			//SortOrder = (SortOrders)Enum.Parse(typeof(SortOrders), token["SortOrder"].ToString());

			Tasks = new List<Task>();
			foreach (JToken taskToken in token["Tasks"])
				Tasks.Add(new Task(taskToken));

		}

		public TaskList(string name)
			: this(name, new List<Task>()) { }

		public TaskList(string name, List<Task> tasks) {

			Name = name;
			Tasks = tasks;

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

		/// <summary>
		/// Reorders the list according to the next item in the <see cref="TaskList"/>.<see cref="SortOrders"/>
		/// </summary>
		public void DoNextSortOrder() {

			switch (SortOrder) {
				case SortOrders.Alphabetical: {
					SortByDateCreated();
					break;
				}
				case SortOrders.DateCreated: {
					SortByDueDate();
					break;
				}
				case SortOrders.DueDate: {
					SortByPriority();
					break;
				}
				case SortOrders.Priority: {
					SortByAlphabetical();
					break;
				}
			}

		}

		private void SortByAlphabetical() {

			// TODO: Sort `Tasks` alphabetically

			// ^^^

			SortOrder = SortOrders.Alphabetical;
			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByDateCreated() {

			// TODO: Sort `Tasks` by Task.DateCreated

			// ^^^

			SortOrder = SortOrders.DateCreated;
			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByDueDate() {

			// TODO: Sort `Tasks` by Task.DueDate

			// ^^^

			SortOrder = SortOrders.DueDate;
			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

		private void SortByPriority() {

			// TODO: Sort `Tasks` by Task.Priority

			// ^^^

			SortOrder = SortOrders.Priority;
			Changed?.Invoke(this, new TaskListChangedEventArgs(null, TaskListChangedEventArgs.ChangeTypes.Reordered));

		}

	}

}
