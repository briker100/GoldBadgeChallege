using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    class Program
    {
        static void Main(string[] args)
        {

            CarRepository theList = new CarRepository();

            Car Info1 = new Car("Honda", 1289);

            theList.addCartoList(Info1);

            theList.printList(theList.printList());
            Console.WriteLine("Would You Like To Add A Car");
            var response = Console.ReadLine();
            while (response == "yes")
            {
                Console.WriteLine("Enter The Model of Car \t");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Year it was made\t");
                string LastName = Console.ReadLine();
                //Console.WriteLine("Enter The Type of Insurence ect. Current,Potential or Past. \t");
                //string Type = Console.ReadLine();


                Console.WriteLine("Would You Like To Delete a Car");
                response = Console.ReadLine();
                if (response == "yes")
                    Console.WriteLine("What Car Do You Want To Delete");
                var CarToDelete = Console.ReadLine();

                foreach (var Car in theList.Info)
                {
                    if (Car.TypeofCar == CarToDelete)
                    {
                        theList.RemoveCarFromList(Car);
                        break;
                    }
                }
                Console.WriteLine();
                theList.printList(theList.printList());
                Console.ReadLine();
            }
        }
    }
}






