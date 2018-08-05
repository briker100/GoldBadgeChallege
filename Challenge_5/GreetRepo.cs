using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
   public class GreetRepo
    {
           public List<Greet> Info = new List<Greet>();

            public void addInfotoList(Greet theInfo)
            {
                Info.Add(theInfo);
            }

            public List<Greet> printList()
            {
                return Info;
            }

            public void printList(List<Greet> theList)
            {
                foreach (Greet Info in theList)
                {
                    Console.WriteLine(Info);
                }
            }

        public void removeFromList(Greet CustomerToDelete)
        {
            Info.Remove(CustomerToDelete);
        }
        }
    }

