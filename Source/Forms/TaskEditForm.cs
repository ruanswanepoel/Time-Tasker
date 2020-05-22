
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskEditForm : Form {


		private readonly TasksForm myForm;
		private readonly Task myTask;


		public TaskEditForm(TasksForm form, Task task) {

			InitializeComponent();

			BackgroundImage = form.DarkenedBitmapFromForm();

			myForm = form;
			myTask = task;

			txtMessage.Text = task.Message;

			Show();

		}

		private void TaskEditForm_Click(object sender, EventArgs e) {

			Close();

		}

		private void btnDelete_Click(object sender, EventArgs e) {

			myForm.RemoveTask(myTask);
			Close();

		}

		private void btnSave_Click(object sender, EventArgs e) {

			myTask.SetMessage(txtMessage.Text);
			Close();

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
