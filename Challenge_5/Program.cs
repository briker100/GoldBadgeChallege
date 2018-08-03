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

            Greet Info1 = new Greet("Billy", "Maze", "Potential", "911-911-0911");
            Greet Info2 = new Greet("God", "Almighty", "Current", "111-111-1111");
            Greet Info3 = new Greet("Santa", "TwinkleToes", "Past", "123-456-7890");
            Greet Info4 = new Greet("Jaws", "Jr", "Current", "924-015-1859");

            theList.addInfotoList(Info1);
            theList.addInfotoList(Info2);
            theList.addInfotoList(Info3);
            theList.addInfotoList(Info4);

            theList.printList(theList.printList());

            while (true)
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
                string theAnswer = Console.ReadLine();
                if (theAnswer == "yes")
                {

                }
                else if (theAnswer == "no")
                {
                    Console.WriteLine("Would You Like To Delete a Customer");
                    if (theAnswer == "yes")

                        theList.removeFromList(FirstName);
                    theList.printList(theList.printList());
                }
            
                else if (theAnswer == "no")
                {
                    break;
                }
                }
            }
        }
    }

