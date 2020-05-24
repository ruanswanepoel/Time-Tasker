
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace TimeTasker {

	/// <summary>
	/// Represents a task with a message and a checked value.
	/// </summary>
	public class Task {

		/// <summary>
		/// Invoked when a change is made to the <see cref="Task"/>.
		/// </summary>
		public event TaskChangedEventHandler TaskChanged;


		private bool allowSaving = true;


		/// <summary>
		/// Gets the message for the <see cref="Task"/>
		/// </summary>
		public string Message { get; private set; }
		/// <summary>
		/// Gets wether the <see cref="Task"/> is checked.
		/// </summary>
		public bool IsChecked { get; private set; }
		/// <summary>
		/// Get the date the <see cref="Task"/> was created.
		/// </summary>
		public DateTime DateCreated { get; private set; }
		/// <summary>
		/// Gets the date the <see cref="Task"/> is due.
		/// </summary>
		public DateTime DueDate { get; private set; }
		/// <summary>
		/// Gets the priority the <see cref="Task"/> has.
		/// Higher values have greater priority.
		/// </summary>
		public int Priority { get; private set; }


		public Task(JToken token) {

			Message = token["Message"].ToString();
			IsChecked = token["IsChecked"].ToObject<bool>();
			DateCreated = DateTime.Parse(token["DateCreated"].ToString());
			DueDate = DateTime.Parse(token["DueDate"].ToString());
			Priority = token["Priority"].ToObject<int>();

			TaskChanged += Task_TaskChanged;

		}

		public Task(string message, bool saving = true)
			: this(message, false, saving) { }
		public Task(string message, bool isChecked, bool saving = true)
			: this(message, isChecked, default, saving) { }
		public Task(string message, bool isChecked, DateTime dateCreated, bool saving = true)
			: this(message, isChecked, dateCreated, default, saving) { }
		public Task(string message, bool isChecked, DateTime dateCreated, DateTime dueDate, bool saving = true)
			: this(message, isChecked, dateCreated, dueDate, 0, saving) { }

		public Task(string message, bool isChecked, DateTime dateCreated, DateTime dueDate, int priority, bool saving = true) {

			Message = message;
			IsChecked = isChecked;
			DateCreated = dateCreated;
			DueDate = dueDate;
			Priority = priority;
			saving = allowSaving;

			TaskChanged += Task_TaskChanged;

		}

		private void Task_TaskChanged(object sender, TaskChangedEventArgs e) {

			if (allowSaving)
				Settings.SaveTaskData();

		}

		/// <summary>
		/// Sets the message of the <see cref="Task"/> to the given <see cref="string"/>
		/// </summary>
		/// <param name="msg">New task message</param>
		public void SetMessage(string msg) {

			if (msg == Message)
				return;

			Message = msg;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.MessageChanged));

		}

		public void SetDueDate(DateTime date) {

			if (DueDate == date)
				return;

			DueDate = date;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.DateChanged));

		}

		public void SetPriority(int priority) {

			if (Priority == priority)
				return;

			Priority = priority;
			TaskChanged?.Invoke(this, new TaskChangedEventArgs(TaskChangedEventArgs.ChangeTypes.PriorityChanged));

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

		public string ToJson() {

			string checkstr = (IsChecked) ? "true" : "false";

			string result = "{\n";
			result += "\"Message\": \"" + Message + "\",\n";
			result += "\"IsChecked\": " + checkstr + ",\n";
			result += "\"DateCreated\": \"" + DateCreated.ToString() + "\",\n";
			result += "\"DueDate\": \"" + DueDate.ToString() + "\",\n";
			result += "\"Priority\": " + Priority.ToString() + "\n";
			result += "}";

			return result;

		}

	}

}
