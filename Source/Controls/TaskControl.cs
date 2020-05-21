
using System;
using System.Windows.Forms;


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

			lblText.Text = myTask.Message;

		}

		private void lblText_Click(object sender, EventArgs e) {

			new TaskEditForm(myForm, myTask);

		}

	}

}
