using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {

            menu_Repo MenuRepo = new menu_Repo();
            var meal = MenuRepo.GetList();

            Console.WriteLine("What Would You Like To Order, Please Enter A Number");
            Console.WriteLine("We Have  #1 Bacon Burger, #2 Bacon Sald, #3 Bacon Soda, and #4 Chocolate Cake");
            Console.WriteLine("I Would Like A Number:");
            //  Console.WriteLine("Here Is What We Currently Have");


            MenuItem Burger = new MenuItem("Bacon Burger", 12.99, "A Warm Crispy Bacon Burger With Over-Flowing Juices and a soft seaseme bun to die for. Includes bun, Meat, Lettuce, Bacon, Tomatoes, Ketchup, and more.", "Bun, Tomatoes, Picles, Lettuce and Sauce", 1);
            MenuItem Salad = new MenuItem("Bacon Salad", 9.99, "A crunchy ice cold salad with tomatoes, onions, cucumbers, Ranch, Carrots, and more. ", "Lettuce, Onions, Cucumbers, Picles, Olives, and more", 2);
            MenuItem Soda = new MenuItem("Bacon Soda", 1.99, "A Free Choice Of twelve imported drinks made in Indiana", "Water and Sugar", 3);
            MenuItem Cake = new MenuItem("Chocolate Cake", 16.99, "A Warm Goey Cake that Melts In Your Mouth And Clogs Your Throat Until You Cant Breathe.", "Chocolate, Flour, Pastry Dough, Whip Cream and Ice Cream", 4);



            MenuRepo.AddItemToMenu(Burger);
            MenuRepo.AddItemToMenu(Salad);
            MenuRepo.AddItemToMenu(Soda);
            MenuRepo.AddItemToMenu(Cake);


            // MenuRepo.PrintList(MenuRepo.GetList());
            //  foreach (var number in menu)
            //{
            //    Console.WriteLine($"{number.Name} \n" +
            //        $"${number.Price} \n" +
            //        $"{number.Description} \n" +
            //        $"#{number.Number} \n");
            //}
            // MenuRepo.PrintList(MenuRepo.GetList());

            int number = int.Parse(Console.ReadLine());

            MenuItem order = MenuRepo.FindMenubyNumber(number);
            Console.WriteLine("Your Order Is");
            Console.WriteLine("\n");
            Console.WriteLine(order.Name);
            Console.WriteLine("\n");
            Console.WriteLine(order.Price);
            Console.WriteLine("\n");
            Console.WriteLine(order.Description);
            Console.WriteLine("\n");
            Console.WriteLine(order.Ingred);
            Console.WriteLine("\n");

            Console.WriteLine("\n");


            Console.WriteLine("Would You Like To add an item");

            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Please Enter The Name Of Meal");
                string p = Console.ReadLine();
                Console.WriteLine("Please Enter The Price of Meal");
                double o = double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Description of Meal");
                string i = Console.ReadLine();
                Console.WriteLine("Please Enter The Ingrediants of the Meal");
                string u = Console.ReadLine();
                Console.WriteLine("Please Enter TheNumber");
                int n = int.Parse(Console.ReadLine());
                MenuItem newMenuItem = new MenuItem(p, o, i, u, n);

                Console.WriteLine("Here Is the Information for the Meal");

                string l = Console.ReadLine();
                
                    MenuRepo.AddItemToMenu(newMenuItem);

                    MenuRepo.PrintList();
                
                Console.WriteLine($"Name:{p}\n" +
                        $"Number:{n}\n" +
                   $"Price:{o}\n" +
                   $"Description:{i}\n" +
                   $"Ingrediants:{u}\n");

            }
            else if (response == "no")
            {
                Console.WriteLine("Would You Like To Delete an item");
                if (response == "yes")
                {
                    Console.WriteLine("What Item Would You Like To Delete");
                    string t = Console.ReadLine();
                    MenuRepo.RemoveItemFromMenu(t);
                    MenuRepo.PrintList();
                }

            }
          
            MenuRepo.PrintList(MenuRepo.GetList());
            {

                Console.ReadLine();
            }
        }

    }

}
        

    




