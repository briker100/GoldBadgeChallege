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



            Outing s1 = new Outing("Golf", 1, DateTime, 8.00, 120.00);
            Outing s2 = new Outing("Bowling", 1, DateTime, 16.00, 500.00);
            Outing s3 = new Outing("Amusement Park", 1, DateTime, 36.00, 1500.00);
            Outing s4 = new Outing("Concert", 1, DateTime, 60.00, 3000.00);

            Greet.AddOuting(s1);
            Greet.AddOuting(s2);
            Greet.AddOuting(s3);
            Greet.AddOuting(s4);

            Greet.PrintList(Greet.GetOutingList());


            Console.WriteLine("Please Enter The Type of Outing");
            string x = Console.ReadLine();

            Console.WriteLine("Please Enter The Number Of people Going");
            string q = Console.ReadLine();

            Console.WriteLine("Please Enter Month,Day,and Year of Outing");
            string w = Console.ReadLine();

            Console.WriteLine("Please Enter The cost for 1 person to go to the Outing");
            string e = Console.ReadLine();

            Console.WriteLine("Please Enter The cost for everyone to go to the outing");
            string r = Console.ReadLine();

           // DateTime userTime = DateTime.Parse(Console.ReadLine());
            // bool apprunning = true;
            while (true)
            {
                Console.WriteLine("Here Is The Information For The Outing");
                string m = Console.ReadLine();
                if (m == " ")
                {
                    Greet.AddOuting();
                    Greet.GetOutingList();
                }
                Console.WriteLine($"Title:{x}\n" +  
                    $"Number Of People:{q}\n"  +
                    $"Time Of Concert:{w}\n" +
                    $"Cost For a Person:{e}\n" +
                    $"Cost For Event:{r}\n");
                
                Greet.PrintList(Greet.GetOutingList());
                double v = 120 + 500 + 1500 + 3000;
                Console.WriteLine($"Combined Cost Outings:{r} + {v}\n");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
