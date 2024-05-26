using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1.UI;
//using task_1.BL;
//using task_1.DL;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string option = "9";
            while(option != "0")
            {
                option = UserInterface.menu();
                if(option == "1")
                {
                    CoffeeShop.addItem(UserInterface.newItem());
                    Console.WriteLine();
                    Console.WriteLine("Item Added Succesfully.");
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    CoffeeShop.displayCheapestItem();
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    UserInterface.viewDrinksMenu();
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    UserInterface.viewFoodsMenu();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    UserInterface.addOrder();
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    CoffeeShop.fulfillOrders();
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    CoffeeShop.viewOrders();
                    Console.ReadKey();
                }
                else if (option == "8")
                {
                    CoffeeShop.showAmount();
                    Console.ReadKey();
                }
            }
        }

        
    }
}
