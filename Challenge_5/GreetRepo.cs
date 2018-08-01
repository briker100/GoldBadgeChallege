using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class GreetRepo
    {

       
            List<Greet> Info = new List<Greet>();

            public void addInfotoList(Greet theInfo)
            {
                Info.Add(theInfo);
            }

            public List<Greet> getList()
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
            public void removeFromList(string FirstName)
            {
                int theIndex = Info.FindIndex(Info => Info.firstname == FirstName);
                Info.RemoveAt(theIndex);
            }
    }
}
