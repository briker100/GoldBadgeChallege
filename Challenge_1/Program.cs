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



            Console.WriteLine("What Would You Like To Order, Please Enter A Number");
            int Name = int.Parse(Console.ReadLine());
          //  Console.WriteLine("Here Is What We Currently Have");
            
            

            menu_Repo menu1 = new menu_Repo();


            var menu = menu1.GetList();


            

                MenuItem Burger = new MenuItem("Bacon Burger", 12.99, "A Warm Crispy Bacon Burger With Over-Flowing Juices and a soft seaseme bun to die for. Includes bun, Meat, Lettuce, Bacon, Tomatoes, Ketchup, and more.", "Bun, Tomatoes, Picles, Lettuce and Sauce", 1);
                MenuItem Salad = new MenuItem("Bacon Salad", 9.99, "A crunchy ice cold salad with tomatoes, onions, cucumbers, Ranch, Carrots, and more. ", "Lettuce, Onions, Cucumbers, Picles, Olives, and more", 2);
                MenuItem Soda = new MenuItem("Bacon Soda", 1.99, "A Free Choice Of twelve imported drinks made in Indiana", "Water and Sugar", 3);
                MenuItem Cake = new MenuItem("Chocolate Cake", 16.99, "A Warm Goey Cake that Melts In Your Mouth And Clogs Your Throat Until You Cant Breathe.", "Chocolate, Flour, Pastry Dough, Whip Cream and Ice Cream", 4);

       

                menu1.AddItemtoMenu(Burger);
                menu1.AddItemtoMenu(Salad);
                menu1.AddItemtoMenu(Soda);
                menu1.AddItemtoMenu(Cake);

            foreach (var number in menu)
            {
                Console.WriteLine($"{number.Name} \n" +
                    $"${number.Price} \n" +
                    $"{number.Description} \n" +
                    $"#{number.Number} \n");
            }

            



            MenuItem order = menu1.FindMenubyNumber(Name);
            Console.WriteLine("\n");
            Console.WriteLine(order.Name);
            Console.WriteLine("\n");
            Console.WriteLine(order.Price);
            Console.WriteLine("\n");
            Console.WriteLine(order.Description);
            Console.WriteLine("\n");
            Console.WriteLine(order.Ingred);



            

            Console.WriteLine("Would You Like To add an item");

            string response = Console.ReadLine();
            if (response == "yes")
                Console.WriteLine("Please Enter A Name, Price, Decription of the Item, the Ingrediants and the Number");

            //{
            //    menu1.AddItemToMenu();
            //}
            

            else if (response == "no")
                Console.WriteLine("Have A Good Day");
            
            Console.ReadLine();
            
        }
    }
}
