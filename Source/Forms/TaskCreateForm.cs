
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskCreateForm : Form {


		public delegate void OnTaskCreatedHandler(TaskControl task);
		public event OnTaskCreatedHandler OnTaskCreated;

		private Form parentForm;


		public TaskCreateForm(Form parentForm) {

			InitializeComponent();

			this.parentForm = parentForm;

			Bitmap bitmap = new Bitmap(parentForm.Width, parentForm.Height);
			parentForm.DrawToBitmap(bitmap, new Rectangle(0, 0, parentForm.Width, parentForm.Height));

			BackgroundImage = bitmap;

		}

		private void btnCreate_Click(object sender, EventArgs e) {

			TaskControl task = new TaskControl(parentForm);
			task.Message = txtMessage.Text;

			OnTaskCreated?.Invoke(task);

			Close();

		}

		private void TaskCreateForm_Click(object sender, EventArgs e) {

			Close();

		}

	}

}
