using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TimeTasker;


namespace Tests.Source
{

    [TestFixture]
    public class Additional_Tests
    {
        TasksForm mainForm;
        HamMenuForm form;

        [SetUp]
        public void SetUp()
        {
            mainForm = new TasksForm();
            form = new HamMenuForm(mainForm);
        }
        [Test]
        public void TestMe()
        {
            Console.WriteLine("Hello World!");
        }


    }
}
