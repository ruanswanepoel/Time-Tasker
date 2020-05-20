
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

namespace TimeTasker {

	public partial class TasksForm : Form, ITimeTaskerForm {


		private const int initialTaskMarginY = 10;
		private const int taskMarginY = 5;

		public readonly ObservableCollection<TaskControl> tasks = new ObservableCollection<TaskControl>();


		public ObservableCollection<TaskControl> Tasks {
			get { return tasks; }
		}


		public TasksForm() {

			InitializeComponent();

			tasks.CollectionChanged += Tasks_CollectionChanged;

		}

		public void btnAdd_Click(object sender, EventArgs e) {

			TaskCreateForm f = new TaskCreateForm(this);
			f.OnTaskCreated += AddTask;
			f.Show();

		}

		public void AddTask(TaskControl task) {

			task.Parent = pnlTasks;
			tasks.Add(task);

		}

		public void CalculateTaskLocations() {
			for (int i = 0; i < tasks.Count; i++) {
				tasks[i].Location = new Point((this.Width - tasks[i].Width) / 2, (tasks[i].Height + taskMarginY) * i + initialTaskMarginY);
			}
		}

		private void OrderTasks() {
			// TODO: Order tasks
		}

		public void Tasks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {

			OrderTasks();
			CalculateTaskLocations();

		}




		//Unit Testing Methods

		public Exception CreateOutsidePoint(int i)
		{
			try { 
			tasks[i].Location = new Point(555, 999);
			} catch (Exception e)
			{
				return e;
			}
			return null;

		}

		private void pnlTasks_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}
