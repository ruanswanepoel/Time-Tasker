using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTasker;
using NUnit.Framework;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Tests
{

    [TestFixture]
    public class Test_Remove_Task
    {
        private TasksForm _form;
        private TaskControl _task;
        private TaskControl _task2;

        [SetUp]
        public void SetUp()
        {
            _form = new TasksForm();
            _task2 = new TaskControl(_form);
            _task = new TaskControl(_form);
            _task.Message = "What an amazing world";
            _task2.Message = "No way";
            _form.AddTask(_task);
            _form.AddTask(_task2);
        }

        [Test]
        public void Test_Remove_Singular_Test()
        {
            _task2.Delete();
            Assert.IsFalse(_form.Tasks.Count == 2);
        }

        [Test]
        public void Test_Modify_Test_Message()
        {
            _task2.Message = "Change text";
            Assert.IsTrue(MatchTextContains("Change text"));
        }



        public bool MatchTextContains(string message)
        {
            foreach (TaskControl t in _form.Tasks)
            {
                if (t.Message.Equals(message))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
