
using TimeTasker;
using NUnit.Framework;


namespace Tests.Source {

	[TestFixture]
	class Test_Task {

		[Test]
		public void TestCreate() {
			Task t = new Task("This is a test", false);
			Assert.AreEqual(t.Message, "This is a test");
			Assert.IsFalse(t.IsChecked);
		}

		[Test]
		public void TestMessageChanged() {
			Task t = new Task("This is a test", false);
			bool testBool = false;
			t.TaskChanged += (object o, TaskChangedEventArgs e) => {
				testBool = (e.ChangeType == TaskChangedEventArgs.ChangeTypes.MessageChanged);
			};
			t.SetMessage("Test message changed");
			Assert.IsTrue(testBool);
			Assert.AreEqual("Test message changed", t.Message);
		}

		[Test]
		public void TestChecked() {
			Task t = new Task("This is a test", false);
			bool testBool = false;
			t.TaskChanged += (object o, TaskChangedEventArgs e) => {
				testBool = (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Checked);
			};
			t.Check();
			Assert.IsTrue(testBool);
		}

		[Test]
		public void TestUnchecked() {
			Task t = new Task("This is a test", true);
			bool testBool = false;
			t.TaskChanged += (object o, TaskChangedEventArgs e) => {
				testBool = (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Unchecked);
			};
			t.Uncheck();
			Assert.IsTrue(testBool);
		}

		[Test]
		public void TestToggle() {
			Task t = new Task("This is a test", true);
			bool testBool1 = false;
			t.TaskChanged += (object o, TaskChangedEventArgs e) => {
				testBool1 = (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Unchecked);
			};
			t.Toggle();
			Assert.IsTrue(testBool1);
			bool testBool2 = false;
			t.TaskChanged += (object o, TaskChangedEventArgs e) => {
				testBool2 = (e.ChangeType == TaskChangedEventArgs.ChangeTypes.Checked);
			};
			t.Toggle();
			Assert.IsTrue(testBool2);
		}

	}

}
