
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TasksForm : Form {


		private const int c_MARGIN_Y = 5;

		public TaskList Tasklist { get; private set; }


		public TasksForm() {

			InitializeComponent();

			SetTasklist(Settings.StartupList);
			btnSortOrder.Text = Tasklist.SortOrder.ToFriendlyString();
			Tasklist.Changed += Tasklist_Changed;
			Draw();

		}

		public TasksForm(TaskList list)
		{
			Tasklist = list;
		}

		public void Draw() {

			BackColor = Settings.MainColor;
			pnlTitle.BackColor = Settings.ColorTheme;
			pnlNavbar.BackColor = Settings.ColorTheme;
			lblSortOrder.ForeColor = Settings.TextColor;
			btnSortOrder.ForeColor = Settings.TextColor;
			btnTasks.BackColor = Settings.AppColor;

			DrawTasks();

		}

		public void DrawTasks() {

			pnlTasks.Controls.Clear();

			List<Task> unCompleted = new List<Task>();
			List<Task> completed = new List<Task>();

			foreach (Task t in Tasklist.Tasks) {
				if (t.IsChecked)
					completed.Add(t);
				else
					unCompleted.Add(t);
			}

			for (int i = 0; i < unCompleted.Count; i++) {
				TaskControl t = new TaskControl(this, unCompleted[i]);
				t.Parent = pnlTasks;
				t.Location = new Point((Width - t.Width) / 2, (t.Height + c_MARGIN_Y) * i);
			}

			if (!Settings.HideCompletedTasks) {
				if (completed.Count > 0) {
					Label lbl = new Label() {
						Parent = pnlTasks,
						Location = new Point(0, (40 + c_MARGIN_Y) * unCompleted.Count),
						Size = new Size(360, 20),
						Text = "Copmleted",
						TextAlign = ContentAlignment.MiddleCenter,
						ForeColor = Settings.TextColor,
						Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
					};
					for (int i = 0; i < completed.Count; i++) {
						TaskControl t = new TaskControl(this, completed[i]);
						t.Parent = pnlTasks;
						t.Location = new Point((Width - t.Width) / 2, (t.Height + c_MARGIN_Y) * i + ((t.Height + c_MARGIN_Y) * unCompleted.Count) + 25);
					}
				}
			}

		}

		public void SetTasklist(TaskList list) {

			Tasklist = list;
			lblList.Text = list.Name;
			Tasklist.Changed += Tasklist_Changed;

			DrawTasks();

			Settings.SetStartupListIndex(list);

		}

		public void AddTask(Task task) {
			
			Tasklist.AddTask(task);

		}

		public void RemoveTask(Task task) {

			Tasklist.RemoveTask(task);

		}

		private void Tasklist_Changed(object sender, TaskListChangedEventArgs e) {

			if (e.ChangeType != TaskListChangedEventArgs.ChangeTypes.Reordered)
				Tasklist.Sort();

			DrawTasks();
			Settings.SaveTaskData();

		}

		private void btnMenu_Click(object sender, EventArgs e) {

			new HamMenuForm(this);

		}

		public void btnAdd_Click(object sender, EventArgs e) {

			new TaskCreateForm(this);

		}

		private void btnSortOrder_Click(object sender, EventArgs e) {

			Tasklist.DoNextSortOrder();
			btnSortOrder.Text = Tasklist.SortOrder.ToFriendlyString();

		}

		private void btnCalendar_Click(object sender, EventArgs e) {

			this.LoadForm(new NotificationForm());

		}

		private void btnUserSettings_Click(object sender, EventArgs e) {

			this.LoadForm(new UserSettingsForm());

		}


		private void pnlHorizontalLinearGradient(object sender, PaintEventArgs e) {

			Point startPoint = new Point(50, 10);
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
