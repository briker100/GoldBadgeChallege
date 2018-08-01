using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Outing
    {
        public string Type { get; set; }
        public double NumberPeople { get; set; }
        public DateTime Now { get; set; }
        public double CostPerson { get; set; }
        public double CostEvent { get; set; }


        public Outing(string t, double n, DateTime q, double cp, double ce)
        {
            Type = t;
            NumberPeople = n;
            Now = q;
            CostPerson = cp;
            CostEvent = ce;

        }

        public override string ToString()
        {
            return $"Title: {Type}\n" +
                $"Number of People: { NumberPeople}\n" +
                $"Time Of Concert:{Now}\n" +
                $"Cost of A Person: {CostPerson}\n" +
                $"Cost of The Event:{CostEvent}\n";

        }
    }
}
