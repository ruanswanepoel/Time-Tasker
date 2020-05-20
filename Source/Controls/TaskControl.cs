
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskControl : UserControl {


		public string Message {
			get { return lblText.Text; }
			set { lblText.Text = value; }
		}


		public TaskControl() {

			InitializeComponent();

		}

		private void lblText_Click(object sender, EventArgs e) {

			TaskSettingsControl popup = new TaskSettingsControl(this);
			popup.Parent = Parent;
			popup.Location = new Point((Parent.Width - popup.Width) / 2, (Parent.Height - popup.Height) / 2);
			popup.BringToFront();

		}

	}

}
