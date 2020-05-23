
using System;
using System.Drawing;
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

		public void Draw() {

			BackColor = Settings.MainColor;
			pnlTitle.BackColor = Settings.ColorTheme;
			pnlNavbar.BackColor = Settings.ColorTheme;
			lblSortOrder.ForeColor = Settings.TextColor;
			btnSortOrder.ForeColor = Settings.TextColor;

			DrawTasks();

		}

		public void SetTasklist(TaskList list) {

			Tasklist = list;
			lblList.Text = list.Name;
			Tasklist.Changed += Tasklist_Changed;

			DrawTasks();

		}

		public void DrawTasks() {

			pnlTasks.Controls.Clear();

			for (int i = 0; i < Tasklist.Tasks.Count; i++) {
				TaskControl t = new TaskControl(this, Tasklist.Tasks[i]);
				t.Parent = pnlTasks;
				t.Location = new Point((Width - t.Width) / 2, (t.Height + c_MARGIN_Y) * i);
			}

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

	}

}
