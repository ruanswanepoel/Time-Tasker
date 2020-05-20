
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskCreateControl : UserControl {


		public delegate void OnTaskCreatedHandler(TaskControl task);
		public event OnTaskCreatedHandler OnTaskCreated;


		public TaskCreateControl() {

			InitializeComponent();

		}

		private void btnClose_Click(object sender, EventArgs e) {

			Dispose();

		}

		private void btnCreate_Click(object sender, EventArgs e) {

			TaskControl task = new TaskControl();
			task.Message = txtMessage.Text;

			OnTaskCreated?.Invoke(task);
			
			Dispose();

		}

	}

}
