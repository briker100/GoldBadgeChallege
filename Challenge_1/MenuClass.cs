using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{

    public class MenuItem
    {
        //Constructor
        public MenuItem() { }

        //Constructor
        public MenuItem(string t, double p, string r, string i, int n)
        {
            Name = t;
            Price = p;
            Description = r;
            Ingred = i;
            Number = n;
        }


        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Ingred { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return Name;
                
        }
    }
    }

