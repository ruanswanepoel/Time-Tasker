
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

			pnl1.BackColor = Settings.ColorTheme;
			pnl2.BackColor = Settings.ColorTheme;
			pnl3.BackColor = Settings.ColorTheme;
			pnl4.BackColor = Settings.ColorTheme;

			txtMessage.Text = task.Message;
			dtpDueDate.Value = task.DueDate;
			drpPriority.SelectedIndex = task.Priority;

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
			myTask.SetDueDate(dtpDueDate.Value);
			myTask.SetPriority(drpPriority.SelectedIndex);
			Close();

		}
	
	}

}
