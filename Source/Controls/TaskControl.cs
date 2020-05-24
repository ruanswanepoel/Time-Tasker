
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

			Draw();

		}

		public void Draw() {

			lblText.Text = myTask.Message;

			if (myTask.IsChecked)
				btnCheckbox.Image = Resources.CheckboxChecked;
			else
				btnCheckbox.Image = Resources.CheckboxEmpty;

		}

		private void MyTask_TaskChanged(object sender, TaskChangedEventArgs e) {

			Draw();

		}

		private void lblText_Click(object sender, EventArgs e) {

			new TaskEditForm(myForm, myTask);

		}

		private void btnCheckbox_Click(object sender, EventArgs e) {

			if (myTask.IsChecked)
				myTask.Uncheck();
			else
				myTask.Check();

			myForm.DrawTasks();

		}

	}

}
