using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using TimeTasker;

namespace Tests.Source
{
    [TestFixture]
    public class Test_HamMenu
    {
        TaskList fakeList;
        HamMenuForm menu;
        

        [SetUp]
        public void SetUp()
        {
            List<TaskList> MyTasks = new List<TaskList>();
            MyTasks.Add(new TaskList("this list", new List<Task>(), false));


            fakeList = new TaskList("A cool default list", new List<Task>(), false);
            menu = new HamMenuForm(MyTasks, fakeList);
            
            
        }
        [Test]
        public void Test_Add_List_To_Hamburger_Menu()
        {
            menu.AddList(fakeList);
            Assert.AreEqual(menu.lists[0], fakeList);
        }

        [Test]
        public void Test_Remove_List_From_Hamburger_Menu()
        {
            menu.AddList(fakeList);
            menu.RemoveList(fakeList);
            Assert.AreEqual(menu.lists.Count, 0);
        }
    }
}
