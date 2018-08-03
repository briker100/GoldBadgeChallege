using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Outing
    {
        public string Name { get; set; }
        public double NumberofPeople { get; set; }
        public DateTime Time { get; set; }
        public double CostPerson { get; set; }
        public double CostEvent { get; set; }

        public Outing(string name, double numberofpeople, DateTime time, double Costperson, double Costevent)
        {
            Name = name;
            NumberofPeople = numberofpeople;
            Time = time;
            CostPerson = Costperson;
            CostEvent = Costevent;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Number of People: { NumberofPeople}\n" +
                $"When The Concert is: {Time}\n" +
                $"Cost a Person to go in Outing {CostPerson}\n" +
                $"Cost of a Entire Event{CostEvent}\n";

        }
    }
}
