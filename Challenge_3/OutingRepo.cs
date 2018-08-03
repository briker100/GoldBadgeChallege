using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepo
    {
        List<Outing> _Outing = new List<Outing>();

        public void AddOuting(Outing s)
        {
            _Outing.Add(s);
        }
        
        //List<OutingRepo> Outing1 = new List<OutingRepo>();

        public void RemoveOuting(Outing s)
        {
            _Outing.Remove(s);
        }

        public List<Outing> GetOutingList()
        {
            return _Outing;
        }

        public void PrintList(List<Outing> list)
        {
            foreach (Outing item in list)   
            {
                Console.WriteLine(item);
            }
        }
    }
}
