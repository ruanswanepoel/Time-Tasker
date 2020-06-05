using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTasker;
using NUnit.Framework;
using System.Security.Cryptography;

namespace Tests.Source
{
    [TestFixture]
    public class Test_TaskList
    {
        TaskList form;
        Task a;
        Task b;
        Task c;


        [SetUp]
        public void SetUp()
        {
            form = new TaskList("afwaf", new List<Task>(), false);
            a = new Task("a", false, new DateTime(2020, 05, 01), new DateTime(2020, 06, 01), 4, false);
            b = new Task("b", false, new DateTime(2020, 05, 02), new DateTime(2020, 06, 02), 5, false);
            c = new Task("c", false, new DateTime(2020, 05, 03), new DateTime(2020, 06, 03), 3, false);
            form.AddTask(a);
            form.AddTask(b);
            form.AddTask(c);
        }

        [Test]
        public void SortOrderCreated()
        {
            form.SortByDateCreated();
            form.Tasks[0].Equals(a); //Message = "a"
            form.Tasks[1].Equals(b); //Message = "b"
            form.Tasks[2].Equals(c); //Message = "c"
        }

        [Test]
        public void SortOrderAlphabetically()
        {
            form.SortByAlphabetical(); 
            form.Tasks[0].Equals(a); //Message = "a"
            form.Tasks[1].Equals(b); //Message = "b"
            form.Tasks[2].Equals(c); //Message = "c"
        }

        [Test]
        public void SortOrderPriority()
        {
            form.SortByPriority();
            form.Tasks[0].Equals(b); //Message = "a"
            form.Tasks[1].Equals(a); //Message = "b"
            form.Tasks[2].Equals(c); //Message = "c"
        }

        [Test]
        public void SortOrderDueDate()
        {
            form.SortByDueDate();
            form.Tasks[0].Equals(c); //Message = "a"
            form.Tasks[1].Equals(b); //Message = "b"
            form.Tasks[2].Equals(a); //Message = "c"
        }






    }
}
