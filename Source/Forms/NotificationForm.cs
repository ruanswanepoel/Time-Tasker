
using System.Windows.Forms;


namespace TimeTasker {

	public partial class NotificationForm : Form {

		public NotificationForm() {

			InitializeComponent();

			Draw();

		}

		public void Draw() {

			BackColor = Settings.MainColor;
			pnlTitle.BackColor = Settings.ColorTheme;
			pnlNavbar.BackColor = Settings.ColorTheme;
			label1.ForeColor = Settings.TextColor;

		}

		private void btnTasks_Click(object sender, System.EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void btnUserSettings_Click(object sender, System.EventArgs e) {

			this.LoadForm(new UserSettingsForm());

		}

	}

}
