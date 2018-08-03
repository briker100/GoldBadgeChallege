using System;
using Challenge_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_5_Tests
{
    [TestClass]
    public class UnitTest1
    {
        public GreetRepo _Greet = new GreetRepo();

        [TestMethod]
        public void GreetRepo_addInfotoList_ShouldAddAnItemToList()
        {
            Greet Info1 = new Greet("Billy", "Maze", "Potential", "911-911-0911");
            _Greet.addInfotoList(Info1);

            var actual = _Greet.addInfotoList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreetRepo_GetList_ShouldGetTheList()
        {
            Greet GetList = new Greet();
            _Greet.GetList(Greet);

            var actual = _Greet.GetList();
            var expected = Info;
        }

        [TestMethod]
        public void GreetRepo_printList_ShouldPrintTheList()
        {
            Greet printList = new Greet()
                Greet.printList(_Greet);
            var actual = _Greet.printList();
            var expected = menu;
        }

        [TestMethod]
        public void GreetRepo_removeFromList_ShouldRemoveFromTheList()
        {
            Greet Info1 = new Greet("Billy", "Maze", "Potential", "911-911-0911");
            _Greet.removeFromList(Info1);

            var actual = _Greet.removeFromList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
       
    }
}
