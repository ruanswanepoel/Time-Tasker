
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskSettingsControl : UserControl {


		private TaskControl task;


		public TaskSettingsControl(TaskControl task) {

			InitializeComponent();

			this.task = task;
			txtMessage.Text = task.Message;

		}

		private void btnClose_Click(object sender, EventArgs e) {

			Dispose();

		}

		private void btnDelete_Click(object sender, EventArgs e) {

			task.Dispose();
			Dispose();

		}

		private void btnSave_Click(object sender, EventArgs e) {

			task.Message = txtMessage.Text;
			Dispose();

		}

	}

}
