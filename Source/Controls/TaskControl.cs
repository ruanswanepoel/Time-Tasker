
using System;
using System.Windows.Forms;
using TimeTasker.Properties;

namespace TimeTasker {

	public partial class TaskControl : UserControl {


		private readonly TasksForm myForm;
		private readonly Task myTask;


		public TaskControl(TasksForm form, Task task) {

			InitializeComponent();

			lblText.Text = task.Message;

			myForm = form;
			myTask = task;

			myTask.TaskChanged += MyTask_TaskChanged;

		}

		private void MyTask_TaskChanged(object sender, TaskChangedEventArgs e) {

			if (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Checked)
				btnCheckbox.Image = Resources.ButtonPlus;
			else if (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Unchecked)
				btnCheckbox.Image = Resources.ButtonHamMenu;
			else
				lblText.Text = myTask.Message;

		}

		private void lblText_Click(object sender, EventArgs e) {

			new TaskEditForm(myForm, myTask);

		}

		private void btnCheckbox_Click(object sender, EventArgs e) {

			if (myTask.IsChecked)
				myTask.Uncheck();
			else
				myTask.Check();

		}

	}

}
