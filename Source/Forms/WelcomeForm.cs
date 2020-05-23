
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class WelcomeForm : Form {

		public WelcomeForm() {
			InitializeComponent();
		}

		private void btnProceed_Click(object sender, EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void chkShowWelcome_CheckedChanged(object sender, EventArgs e) {



		}

	}

}
