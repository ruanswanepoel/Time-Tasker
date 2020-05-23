
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class UserSettingsForm : Form {

		public UserSettingsForm() {

			InitializeComponent();

		}

		private void btnTasks_Click(object sender, EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void btnCalendar_Click(object sender, EventArgs e) {

			this.LoadForm(new NotificationForm());

		}

	}

}
