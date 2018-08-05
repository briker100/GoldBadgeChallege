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

            Greet Info1 = new Greet("Billy", "Maze", "Potential", "SaviorofElves@gmail.com");
            Greet Info2 = new Greet("God", "Almighty", "Current", "theBigBoss@gmail.com");
            Greet Info3 = new Greet("Santa", "TwinkleToes", "Past", "TheHiddenWorkshop@gmail.com");
            Greet Info4 = new Greet("Jaws", "Jr", "Current", "TheDeepBlue@gmail.com");

            theList.addInfotoList(Info1);
            theList.addInfotoList(Info2);
            theList.addInfotoList(Info3);
            theList.addInfotoList(Info4);

            theList.printList(theList.printList());
            Console.WriteLine("Would You Like To Add A Customer");
            var response = Console.ReadLine();
            while (response == "yes")
            {
                Console.WriteLine("Enter The FirstName \t");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name \t");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter The Type of Insurence ect. Current,Potential or Past. \t");
                string Type = Console.ReadLine();


                Console.WriteLine("Enter The Email \n\t");
                string Email = Console.ReadLine();

                Greet userShow = new Greet(FirstName, LastName, Type, Email);
                if (Type == "Current")
                {
                    Console.WriteLine("Thank you for your work with us.We appreciate your loyalty.Here's a coupon.");
                }
                else if (Type == "Past")
                {
                    Console.WriteLine("It's been a long time since we've heard from you, we want you back.");
                }
                else if (Type == "Potential")
                {
                    Console.WriteLine("We currently have the lowest rates on Helicopter Insurance!");
                }
                theList.addInfotoList(userShow);

                Console.WriteLine("Do You Want To Add Another Customer");
                response = Console.ReadLine();
            }

            Console.WriteLine("Would You Like To Delete a Customer");
            response = Console.ReadLine();
            if (response == "yes")
                Console.WriteLine("What Customer Do You Want To Delete");
            var CustomerToDelete = Console.ReadLine();

            foreach (var Greet in theList.Info)
            {
                if (Greet.Firstname == CustomerToDelete)
                {
                    theList.removeFromList(Greet);
                    break;
                }
            }
            Console.WriteLine();
            theList.printList(theList.printList());
            Console.ReadLine();
        }
    }
}

        



