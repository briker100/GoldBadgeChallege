using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {

            GreetRepo theList = new GreetRepo();

            Greet Info1 = new Greet("Billy", "Maze", "Car", "911-911-0911");
            Greet Info2 = new Greet("God", "Almighty", "House", "111-111-1111");
            Greet Info3 = new Greet("Santa", "TwinkleToes", "House", "123-456-7890");
            Greet Info4 = new Greet("Jaws", "Jr", "Theft", "924-015-1859");



            while (true)
            {
                Console.WriteLine("Enter The FirstName \t");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name \t");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter The Type of Insurence ect. Car,Theft or House. \t");
                string Type = Console.ReadLine();
                Console.WriteLine("Enter The Email \t");
                string Email = Console.ReadLine();

                Greet userShow = new Greet(FirstName, LastName, Type, Email);

                theList.addInfotoList(userShow);

                Console.WriteLine("Do You Want To Add Another Customer");
                string theAnswer = Console.ReadLine();
                if (theAnswer == "yes")
                {

                }
                else if (theAnswer == "no")
                {
                    break;
                }
            }
            theList.printList(theList.getList());



            Console.WriteLine("What Show Do You Want To Remove");
            string show = Console.ReadLine();
            theList.removeFromList(show);

            theList.addInfotoList(Info1);
            theList.addInfotoList(Info2);
            theList.addInfotoList(Info3);
            theList.addInfotoList(Info4);

            Console.ReadLine();



        }
    }
}
