using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {

            OutingRepo Greet = new OutingRepo();

            Greet.PrintList(Greet.GetOutingList());

            DateTime DateTime = new DateTime(2018, 2, 4);
            // DateTime.Parse(Console.ReadLine());
            // DateTime userTime = DateTime.Parse(Console.ReadLine());
            // Console.WriteLine("Please Enter The Info to make a new Outing");



            Outing e1 = new Outing("Golf", 1, DateTime, 8.00, 120.00);
            Outing e2 = new Outing("Bowling", 1, DateTime, 16.00, 500.00);
            Outing e3 = new Outing("Amusement Park", 1, DateTime, 36.00, 1500.00);
            Outing e4 = new Outing("Concert", 1, DateTime, 60.00, 3000.00);

            Greet.AddOuting(e1);
            Greet.AddOuting(e2);
            Greet.AddOuting(e3);
            Greet.AddOuting(e4);

            Greet.PrintList(Greet.GetOutingList());


            Console.WriteLine("Please Enter The Type of Outing");
            string Type = Console.ReadLine();

            Console.WriteLine("Please Enter The Number Of people Going");
            double Number = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Month,Day,and Year of Outing");
            DateTime Date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The cost for 1 person to go to the Outing");
            double Cost1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The cost for everyone to go to the outing");
            double CostAll = double.Parse(Console.ReadLine());


            // DateTime userTime = DateTime.Parse(Console.ReadLine());
            // bool apprunning = true;
            Outing Event = new Outing(Type, Number, Date, Cost1, CostAll);
            while (true)
            {

                Console.WriteLine("Here Is The Information For The Outing");
                string m = Console.ReadLine();
                if (m == " ")
                {
                    Greet.AddOuting(Event);
                    Greet.GetOutingList();
                }
                Console.WriteLine($"Title:{Type}\n" +  
                    $"Number Of People:{Number}\n"  +
                    $"Time Of Concert:{Date}\n" +
                    $"Cost For a Person:{Cost1}\n" +
                    $"Cost For Event:{CostAll}\n");
                
                
                Greet.PrintList(Greet.GetOutingList());
                double v = 120 + 500 + 1500 + 3000; 
                Console.WriteLine($"Combined Cost Outings:{CostAll} + {v}\n");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
