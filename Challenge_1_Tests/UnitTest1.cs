using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class UnitTest1
    {

        public menu_Repo _menu = new menu_Repo();

        [TestMethod]
        public void Menu_Repo_AddItemToMenu_ShouldAddMenuList()
        {
            MenuItem Burger = new MenuItem("Bacon Burger", 12.99, "A Warm Crispy Bacon Burger With Over-Flowing Juices and a soft seaseme bun to die for. Includes bun, Meat, Lettuce, Bacon, Tomatoes, Ketchup, and more.", "Bun, Tomatoes, Picles, Lettuce and Sauce", 1);
            _menu.AddItemToMenu(Burger);

            var actual = _menu.PrintList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_Repo_FindMenubyNumber_ShouldFindMenuItembyNumber()
        {
            int lookup = new int();
            _menu.FindMenubyNumber(lookup);


            var actual = _menu.PrintList();
            var expected = lookup;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_Repo_GetList_ShouldGetTheList()
        {
            MenuItem GetList = new MenuItem();
            _menu.PrintList();

            var actual = _menu.PrintList().Count;
            var expected = GetList;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_Repo_RemoveItemFromMenu_ShouldRemoveMenuList()
        {
            MenuItem meal = new MenuItem("Bacon Burger", 12.99, "A Warm Crispy Bacon Burger With Over-Flowing Juices and a soft seaseme bun to die for. Includes bun, Meat, Lettuce, Bacon, Tomatoes, Ketchup, and more.", "Bun, Tomatoes, Picles, Lettuce and Sauce", 1);
            _menu.AddItemToMenu(meal);
            _menu.RemoveItemFromMenu(meal);
            List<MenuItem> stuff = _menu.PrintList();

            var actual = stuff.Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);

        }
    
        [TestMethod]
        public void Menu_Repo_PrintList_ShouldPrintTheList()
        {
            MenuItem PrintList = new MenuItem();
            _menu.PrintList();

            var actual = _menu.PrintList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
