using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class UnitTest2
    {

        public OutingRepo _OutingRepo = new OutingRepo();
        
        [TestMethod]
        public void OutingRepo_AddOuting_ShouldAddAOutingList1()
        {
            Outing e1 = new Outing("Golf", 1, DateTime.Now, 8.00, 120.00);
            _OutingRepo.AddOuting(e1);

            var actual = _OutingRepo.GetOutingList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void OutingRepo_RemoveOuting_ShouldRemoveAnOuting()
        //{
        //    Outing e1 = new Outing("Golf", 1, DateTime.Now, 8.00, 120.00);
        //    _OutingRepo.RemoveOuting(e1);

        //    var actual = _OutingRepo.RemoveOuting(e1).Count;
        //    var expected = 1;

        //    Assert.AreEqual(expected, actual);
      //  }

        [TestMethod]
        public void OutingRepo_GetOutingList_ShouldGiveList()
        {
           // Outing GetOutingList = new Outing("golf", 10, DateTime.Now, 34, 67);
            List<Outing> thing = _OutingRepo.GetOutingList();

            var actual = thing.Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void OutingRepo_PrintList_ShouldPrintTheList()
        //{
        //    Outing e1 = new Outing("Golf", 1, DateTime.Now, 8.00, 120.00);

        //    //Outing PrintList = new Outing();
        //   ////////////////////// _OutingRepo.PrintList();

        //    var actual = OutingRepo.PrintList();
        //    var expected = e1;
        //}




    }
}
