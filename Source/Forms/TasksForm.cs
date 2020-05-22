
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TasksForm : Form {


		private const int c_INITIAL_MARGIN_Y = 60;
		private const int c_MARGIN_Y = 5;

		private TaskList taskList = new TaskList();


		public TasksForm() {

			InitializeComponent();

		}

		public void DrawTasks() {

			for (int i = Controls.Count - 1; i >= 0; i--)
				if (Controls[i] is TaskControl)
					Controls.RemoveAt(i);

			for (int i = 0; i < taskList.Tasks.Count; i++) {
				TaskControl t = new TaskControl(this, taskList.Tasks[i]);
				t.Parent = this;
				t.Location = new Point((Width - t.Width) / 2, (t.Height + c_MARGIN_Y) * i + c_INITIAL_MARGIN_Y);
			}

		}

		public void AddTask(Task task) {

			taskList.AddTask(task);
			DrawTasks();

		}

		public void RemoveTask(Task task) {

			taskList.RemoveTask(task);
			DrawTasks();

		}

		private void btnMenu_Click(object sender, EventArgs e) {

			new HamMenuForm(this);

		}

		public void btnAdd_Click(object sender, EventArgs e) {

			new TaskCreateForm(this);

		}

        private void TasksForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {

        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {

        }
    }

}
