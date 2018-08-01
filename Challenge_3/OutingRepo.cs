using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepo
    {
        List<Outing> _Outing = new List<Outing>();

        public void AddOuting(Outing s)
        {
            _Outing.Add(s);
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

        internal void AddOuting()
        {
            throw new NotImplementedException();
        }
    }
}
