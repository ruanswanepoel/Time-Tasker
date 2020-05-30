
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class HamMenuForm : Form {

		private const int c_INITIAL_MARGIN_Y = 10;
		private const int c_MARGIN_Y = 5;

		private readonly TasksForm myForm;
		public readonly List<TaskList> lists = new List<TaskList>();


		public HamMenuForm(TasksForm form) {

			InitializeComponent();

			myForm = form;
			lists = Settings.Lists;

			BackgroundImage = form.DarkenedBitmapFromForm();

			DrawLists();
			Show();
		}

		public HamMenuForm(List<TaskList> list, TaskList list2) 
		{
			lists = list;
			myForm = new TasksForm(list2);
		}

	

		public void SelectList(TaskList list) {

			myForm.SetTasklist(list);
			Close();

		}

		public void DrawLists() {

			pnlLists.Controls.Clear();

			for (int i = 0; i < lists.Count; i++) {
				TaskListControl t = new TaskListControl(this, lists[i]);
				t.Parent = pnlLists;
				t.Location = new Point((pnlLists.Width - t.Width) / 2, (t.Height + c_MARGIN_Y) * i + c_INITIAL_MARGIN_Y);
			}

		}

		public void AddList(TaskList list) {

			lists.Add(list);
			DrawLists();

		}

		public void RemoveList(TaskList list) {

			lists.Remove(list);
			DrawLists();

		}

		private void TaskListForm_Click(object sender, EventArgs e) {

			Close();

		}

		private void btnSubmit_Click(object sender, EventArgs e) {

			TaskList newList = new TaskList(txtNewListName.Text);
			AddList(newList);
			txtNewListName.Text = "";

		}

	}

}
