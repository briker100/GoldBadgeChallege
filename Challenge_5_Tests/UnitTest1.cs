using System;
using System.Collections.Generic;
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
            Greet Info1 = new Greet("Billy", "Maze", "Potential", "SaviorofElves@gmail.com");
            _Greet.addInfotoList(Info1);

            var actual = _Greet.Info.Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreetRepo_GetList_ShouldGetTheList()
        {
            Greet GetList= new Greet();
            _Greet.printList();

            var actual = _Greet.printList().Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GreetRepo_printList_ShouldPrintTheList()
        {
            List<Greet> some = _Greet.printList();

            var actual = some.Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GreetRepo_removeFromList_ShouldRemoveFromTheList()
        {
            Greet Info1 = new Greet("Billy", "Maze", "Potential", "911-911-0911");
            _Greet.addInfotoList(Info1);
            _Greet.removeFromList(Info1);
            List<Greet> something = _Greet.printList();

            var actual = something.Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
       
    }
}
