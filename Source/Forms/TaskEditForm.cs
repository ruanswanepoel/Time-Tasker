
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskEditForm : Form {


		private readonly TaskControl task;


		public TaskEditForm(Form baseForm, TaskControl task) {

			InitializeComponent();

			Bitmap bitmap = new Bitmap(baseForm.Width, baseForm.Height);
			baseForm.DrawToBitmap(bitmap, new Rectangle(0, 0, baseForm.Width, baseForm.Height));

			BackgroundImage = bitmap;

			this.task = task;
			txtMessage.Text = task.Message;

			Show();

		}

		private void TaskEditForm_Click(object sender, EventArgs e) {

			Close();

		}

		private void btnDelete_Click(object sender, EventArgs e) {

			task.Delete();
			Close();

		}

		private void btnSave_Click(object sender, EventArgs e) {

			task.Message = txtMessage.Text;
			Close();

		}

	}

}
