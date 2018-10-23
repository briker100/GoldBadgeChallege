using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public enum TypeOfClaim { Electric = 1, Gas = 2, Hybrid = 3}

    class Car
    {
        public Car() { }
        public Car(string carType,int yearCarMade, List<string> TypesofCar)
        {
            CarType = carType;
            YearCarMade = yearCarMade;
        }

        public string CarType { get; set; }
        public int YearCarMade { get; set; }
        public List<string> TypesofCar { get; set; }
    }
}
