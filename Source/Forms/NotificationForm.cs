
using System.Drawing;
using System.Drawing.Drawing2D;
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
			btnCalendar.BackColor = Settings.AppColor;
		}

		private void btnTasks_Click(object sender, System.EventArgs e) {

			this.LoadForm(new TasksForm());

		}

		private void btnUserSettings_Click(object sender, System.EventArgs e) {

			this.LoadForm(new UserSettingsForm());

		}

		private void pnlHorizontalLinearGradient(object sender, PaintEventArgs e) {

			Point startPoint = new Point(0, 10);
			Point endPoint = new Point(360, 10);
			Color colour1 = Color.FromArgb(255, 0, 126, 230);  // #007EE6
			Color colour2 = Color.FromArgb(255, 35, 146, 236); // #2392EC
			Color colour3 = Color.FromArgb(255, 85, 174, 246); // #55AEF6

			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(startPoint, endPoint, colour1, colour2);

			ColorBlend colourBlend = new ColorBlend(3);
			colourBlend.Colors = new Color[3] { colour1, colour2, colour3 };
			colourBlend.Positions = new float[3] { 0f, 0.5f, 1f };

			linearGradientBrush.InterpolationColors = colourBlend;

			e.Graphics.FillRectangle(linearGradientBrush, 0, 0, 360, 50);

		}

	}

}
