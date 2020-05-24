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
    public class Test_Order
    {
        TaskList form;
        Task a;
        Task b;
        Task c;


        [SetUp]
        public void SetUp()
        {
            form = new TaskList("afwaf", new List<Task>());
            a = new Task("a", false, new DateTime(2020, 05, 01), new DateTime(2020, 06, 01), 5);
            b = new Task("b", false, new DateTime(2020, 05, 02), new DateTime(2020, 06, 02), 4);
            c = new Task("c", false, new DateTime(2020, 05, 03), new DateTime(2020, 06, 03), 3);
            form.AddTask(a);
            form.AddTask(b);
            form.AddTask(c);
        }

        [Test]
        public void SortOrderAlphabetically()
        {
            form.SortByAlphabetical(); 
            form.Tasks[0].Equals(a); //Message = "a"
            form.Tasks[1].Equals(b); //Message = "b"
            form.Tasks[2].Equals(c); //Message = "c"

        }







    }
}
