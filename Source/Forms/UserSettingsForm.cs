
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class UserSettingsForm : Form {

		public UserSettingsForm() {

			InitializeComponent();

			BackColor = Settings.MainColor;
			pnlTitle.BackColor = Settings.ColorTheme;
			pnlNavbar.BackColor = Settings.ColorTheme;
			lblColorTheme.ForeColor = Settings.TextColor;
			lblDarkmode.ForeColor = Settings.TextColor;
			lblShowWelcome.ForeColor = Settings.TextColor;
			lblHideCompleted.ForeColor = Settings.TextColor;

		}

		private void btnTasks_Click(object sender, EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void btnCalendar_Click(object sender, EventArgs e) {

			this.LoadForm(new NotificationForm());

		}

	}

}
