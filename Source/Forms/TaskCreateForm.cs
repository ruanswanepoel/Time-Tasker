
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskCreateForm : Form {


		private TasksForm myForm;

		public TaskCreateForm(TasksForm form) {

			InitializeComponent();

			myForm = form;

			BackgroundImage = form.DarkenedBitmapFromForm();

			Show();

		}

		private void btnCreate_Click(object sender, EventArgs e) {

			Task task = new Task(txtMessage.Text, false);
			myForm.AddTask(task);

			Close();

		}

		private void TaskCreateForm_Click(object sender, EventArgs e) {

			Close();

		}
    }

}
