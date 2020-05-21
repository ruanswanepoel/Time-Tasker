using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TimeTasker;

namespace Tests
{

    [TestFixture]
    class Test_Categories
    {

        private TasksForm _form;
        private TaskControl _task;
        private TaskList _category;
        [SetUp]
        public void SetUp()
        {
            _form = new TasksForm();
            _task = new TaskControl(_form);
            _category = new TaskList(_form);
        }

        [Test]
        public void Add_Category()
        {

        }

        [Test]
        public void Add_Category_Add_Task()
        {

        }

        [Test]
        public void Add_Category_In_Category()
        {

        }
        [Test]
        public void Test_Limit_Of_Category_In_Category()
        {

        }

        [Test]
        public void Go_Back_When_In_Category()
        {

        }

    }
}
