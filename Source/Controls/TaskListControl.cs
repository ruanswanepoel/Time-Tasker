
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskListControl : UserControl {


		private readonly HamMenuForm myForm;
		private readonly TaskList myList;


		public TaskListControl(HamMenuForm form, TaskList list) {

			InitializeComponent();

			myForm = form;
			myList = list;

			lblName.Text = list.Name;
			list.Changed += List_Changed;

		}

		private void List_Changed(object sender, TaskListChangedEventArgs e) {

			lblName.Text = myList.Name;

		}

		private void lblName_Click(object sender, System.EventArgs e) {

			myForm.SelectList(myList);

		}

	}

}
