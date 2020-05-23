
using System.Windows.Forms;


namespace TimeTasker {

	public partial class NotificationForm : Form {

		public NotificationForm() {

			InitializeComponent();

		}

		private void btnTasks_Click(object sender, System.EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void btnUserSettings_Click(object sender, System.EventArgs e) {

			this.LoadForm(new UserSettingsForm());

		}

	}

}
