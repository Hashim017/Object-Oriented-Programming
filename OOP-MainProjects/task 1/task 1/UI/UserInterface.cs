using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1.UI
{
    class UserInterface
    {
        static int index = 0;
        public static string menu()
        {
            Console.WriteLine("Press One Of The Following Keys.");
            Console.WriteLine();
            Console.WriteLine("1 - Add a Menu Item.");
            Console.WriteLine("2 - View the Cheapest Item.");
            Console.WriteLine("3 - View the Drink's Menu.");
            Console.WriteLine("4 - View the Food's Menu.");
            Console.WriteLine("5 - Add Order.");
            Console.WriteLine("6 - Fulfill the Order.");
            Console.WriteLine("7 - View the Oreder's List.");
            Console.WriteLine("8 - Total Payable Amount.");
            Console.WriteLine("0 - Exit.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }


        public static MenuItem newItem()
        {
            Console.WriteLine();
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();  
            Console.Write("Enter Item Type: ");
            string type = Console.ReadLine(); 
            Console.Write("Enter Item Price (In Rs): ");
            int price = int.Parse(Console.ReadLine());

            MenuItem item = new MenuItem(name, type, price);
            return item;
        }

        public static void viewDrinksMenu()
        {
            int num = 1;
            Console.WriteLine();
            for(int x =0; x<CoffeeShop.menuitems.Count; x++)
            {
                if(CoffeeShop.menuitems[x].ItemType == "drink")
                {
                    Console.WriteLine(num + " - " + "Name: " + CoffeeShop.menuitems[x].ItemName);
                    Console.WriteLine("    " + "Price: " + CoffeeShop.menuitems[x].ItemPrice + " Rs");
                    Console.WriteLine();
                    num++;
                }
            }
        }

        public static void viewFoodsMenu()
        {
            int num = 1;
            Console.WriteLine();
            for (int x = 0; x < CoffeeShop.menuitems.Count; x++)
            {
                if (CoffeeShop.menuitems[x].ItemType == "food")
                {
                    Console.WriteLine(num + " - " + "Name: " + CoffeeShop.menuitems[x].ItemName);
                    Console.WriteLine("    " + "Price: " + CoffeeShop.menuitems[x].ItemPrice + " Rs");
                    Console.WriteLine();
                    num++;
                }
            }
        }

        public static void addOrder()
        {
            Console.Write("Enter Name of Item: ");
            string name = Console.ReadLine();
            bool check = false;
            for(int x = 0; x < CoffeeShop.menuitems.Count; x++)
            {
                if(name == CoffeeShop.menuitems[x].ItemName)
                {
                    check = true;
                }
            }
            if(check)
            {
                CoffeeShop.orders.Add(name);
                Console.WriteLine();
                Console.WriteLine("Item Ordered Successfully ... !");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The " + name + " Is Currently Unavailable ... !");
            }
        }

    }


}
