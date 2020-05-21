
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TimeTasker {

	/// <summary>
	/// Represents a list of type <see cref="Task"/>.
	/// </summary>
	public class TaskList {

		/// <summary>
		/// Invoked when the underlying Tasklist changes.
		/// </summary>
		public event TaskListChangedEventHandler Changed;


		/// <summary>
		/// Gets the underlying <see cref="Task"/> list of the <see cref="TaskList"/>
		/// </summary>
		public List<Task> Tasks { get; private set; }


		public TaskList()
			: this(new List<Task>()) { }
		public TaskList(List<Task> tasks) {

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

	}

}
