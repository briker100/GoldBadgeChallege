using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   public class menu_Repo
    {
        public List<MenuItem> menuList = new List<MenuItem>();

        public void AddItemToMenu(MenuItem Item)
        {
            menuList.Add(Item);
        }

        public MenuItem FindMenubyNumber(int number)
        {
            MenuItem lookup = new MenuItem();

            foreach (MenuItem _menu in menuList)
            {
                if (number == _menu.Number)
                {
                    lookup = _menu;
                    break;
                }
            }
            return lookup;
        }

        public List<MenuItem> GetList()
        {
            return menuList;
        }


        public void RemoveItemFromMenu(MenuItem p)
        {
             menuList.Remove(p);
        }

    public List<MenuItem> PrintList()
        {
            return menuList;
        }

        public void PrintList(List<MenuItem> theList)
        {
            foreach (MenuItem Info in theList)
            {
                Console.WriteLine(Info);
            }
        }

    }
}
