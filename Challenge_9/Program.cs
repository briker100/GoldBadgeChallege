using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_9
{
    public class Info
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What The Name of The Book");
            string name = Console.ReadLine();

            Console.WriteLine("What The Author of The Book");
            string author = Console.ReadLine();

            Console.WriteLine("What The Price of The Book");
            double price = double.Parse(Console.ReadLine());

            Book Books = new Book(name, author, price);
            Console.ReadLine();

        }
    }
}