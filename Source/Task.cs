
using System;

namespace TimeTasker {

	/// <summary>
	/// Represents a task with a message and a checked value.
	/// </summary>
	public class Task {

		/// <summary>
		/// Invoked when a change is made to the <see cref="Task"/>.
		/// </summary>
		public event TaskChangedEventHandler TaskChanged;


		/// <summary>
		/// Gets the message for the <see cref="Task"/>
		/// </summary>
		public string Message { get; private set; }

		/// <summary>
		/// Gets wether this <see cref="Task"/> is checked.
		/// </summary>
		public bool IsChecked { get; private set; }


		public Task()
			: this("", false) { }
		public Task(string msg, bool chk) {

			Message = msg;
			IsChecked = chk;

		}

		/// <summary>
		/// Sets the message of this task to <paramref name="msg"/>
		/// </summary>
		/// <param name="msg">New task message</param>
		public void SetMessage(string msg) {

			if (msg == Message)
				return;

			Message = msg;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.MessageChanged));

		}

		/// <summary>
		/// Checks this <see cref="Task"/>.
		/// </summary>
		public void Check() {

			if (IsChecked)
				return;

			IsChecked = true;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.Checked));

		}

		/// <summary>
		/// Unchecks this <see cref="Task"/>.
		/// </summary>
		public void Uncheck() {

			if (!IsChecked)
				return;

			IsChecked = false;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.Unchecked));

		}

		/// <summary>
		/// Toggles the checked value for this <see cref="Task"/>.
		/// </summary>
		public void Toggle() {

			if (IsChecked)
				Uncheck();
			else
				Check();

		}

	}

}
