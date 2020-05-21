
using System;
using System.Windows.Forms;

namespace TimeTasker {

	public partial class HamMenuForm : Form {


		private Form parentForm;


		public HamMenuForm(Form parentForm) {

			InitializeComponent();

			this.parentForm = parentForm;

			BackgroundImage = parentForm.DarkenedBitmapFromForm();

			Show();

		}

		private void TaskListForm_Click(object sender, EventArgs e) {

			Close();

		}



	}

}
