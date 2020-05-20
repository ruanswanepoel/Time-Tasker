
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TasksForm : Form {


		private const int initialTaskMarginY = 10;
		private const int taskMarginY = 5;

		private readonly ObservableCollection<TaskControl> tasks = new ObservableCollection<TaskControl>();


		public TasksForm() {

			InitializeComponent();

			tasks.CollectionChanged += Tasks_CollectionChanged;

		}

		private void btnAdd_Click(object sender, EventArgs e) {

			TaskCreateControl popup = new TaskCreateControl();
			popup.Parent = this;
			popup.Location = new Point((this.Width - popup.Width) / 2, (this.Height - popup.Height) / 2);
			popup.BringToFront();

			popup.OnTaskCreated += AddTask;

		}

		private void AddTask(TaskControl task) {

			task.Parent = pnlTasks;
			tasks.Add(task);
			task.SetContainer(tasks);

		}

		private void CalculateTaskLocations() {

			for (int i = 0; i < tasks.Count; i++) {
				tasks[i].Location = new Point((this.Width - tasks[i].Width) / 2, (tasks[i].Height + taskMarginY) * i + initialTaskMarginY);
			}

		}

		private void Tasks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {

			CalculateTaskLocations();

		}

	}

}
