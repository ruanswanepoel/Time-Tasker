
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskControl : UserControl {


		private Form parentForm;


		public string Message {
			get { return lblText.Text; }
			set { lblText.Text = value; }
		}


		public TaskControl(Form parentForm) {

			InitializeComponent();

			this.parentForm = parentForm;

		}

		public void Delete() {

			ITimeTaskerForm f = (ITimeTaskerForm)parentForm;
			f.Tasks.Remove(this);

			Dispose();

		}

		private void lblText_Click(object sender, EventArgs e) {

			new TaskEditForm(parentForm, this);

		}

	}

}
