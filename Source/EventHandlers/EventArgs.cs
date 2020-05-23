
using System;


namespace TimeTasker {

	/// <summary>
	/// 
	/// </summary>
	public class TaskListChangedEventArgs : EventArgs {

		public enum ChangeTypes {
			TaskAdded,
			TaskRemoved,
			Reordered
		}

		public Task Task { get; private set; }
		public ChangeTypes ChangeType { get; private set; }

		public TaskListChangedEventArgs(Task task, ChangeTypes changeType) {

			Task = task;
			ChangeType = changeType;

		}

	}

	/// <summary>
	/// 
	/// </summary>
	public class TaskChangedEventArgs : EventArgs {

		public enum ChangeTypes { 
			MessageChanged,
			DateChanged,
			PriorityChanged,
			Checked,
			Unchecked
		}

		public ChangeTypes ChangeType { get; private set; }

		public TaskChangedEventArgs(ChangeTypes changeType) {

			ChangeType = changeType;

		}

	}

}
