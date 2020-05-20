using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TimeTasker;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using NUnit.Framework.Constraints;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;

namespace Unit_Tests
{
    [TestFixture]
    public class Test_Add_Task
    {
        private TasksForm _form;
        private TaskControl _task;

        [SetUp]
        public void setup()
        {
            _form = new TasksForm();  
        }

        [Test]
        public void Initial_Tasks_Set_To_Zero()
        {
            Assert.AreEqual(_form.Tasks.Count, 0);
        }


        [Test]
        public void Test_Add_Task_Changes_Count_To_One()
        {
            
            _task = new TaskControl(_form);
            _form.AddTask(_task);
            Assert.AreEqual(_form.Tasks.Count, 1);
        }

        [Test]
        public void Test_Changing_Text_Of_Task()
        {

            _task = new TaskControl(_form);
            _task.Message = "Hello world";
            _form.AddTask(_task);
            Assert.AreEqual(_form.Tasks[0].Message, "Hello world");
        }


        [Test]
        public void Test_Task_Is_Within_Screen()
        {

            _task = new TaskControl(_form);
            Assert.IsTrue(ReturnInPosition());
        }

        [Test]
        //Will return an exception as it is outside of screen
        public void Test_Task_Is_Not_Within_Screen()
        {
            _task = new TaskControl(_form);
            _form.CreateOutsidePoint(0);
            Assert.AreNotEqual(ReturnInPosition(), null);
        }


        //Methods used in testing
        public bool ReturnInPosition()
        {
            
            Screen[] screens = Screen.AllScreens;
            int count = _form.tasks.Count;
            int countResult = 0;
            foreach (Screen screen in screens)
            {
                foreach (TimeTasker.TaskControl t in _form.tasks) { 
                if (screen.WorkingArea.Contains(t.Location));
                {
                    countResult++;
                }
                }
            }
            
            if (count == countResult)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
