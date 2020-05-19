
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TasksForm : Form {

		private const int initialTaskMarginY = 10;
		private const int taskMarginY = 5;

		private List<TaskControl> tasks;
		private int taskCount = 0;


		public TasksForm() {

			InitializeComponent();

		}

		private void btnAdd_Click(object sender, EventArgs e) {

			TaskControl task = new TaskControl {
				Parent = pnlTasks
			};
			task.Location = new Point((this.Width - task.Width) / 2, (task.Height + taskMarginY) * taskCount + initialTaskMarginY);

			taskCount++;

		}

	}

}
