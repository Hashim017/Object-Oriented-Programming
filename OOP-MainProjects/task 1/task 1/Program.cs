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
            string option = "9";
            while(option != "0")
            {
                header();
                option = UserInterface.menu();
                if(option == "1")
                {
                    header();
                    CoffeeShop.addItem(UserInterface.newItem());
                    Console.WriteLine();
                    Console.WriteLine("Item Added Succesfully.");
                    clearscreen();
                }
                else if (option == "2")
                {
                    header();
                    CoffeeShop.displayCheapestItem();
                    clearscreen();
                }
                else if (option == "3")
                {
                    header();
                    UserInterface.viewDrinksMenu();
                    clearscreen();
                }
                else if (option == "4")
                {
                    header();
                    UserInterface.viewFoodsMenu();
                    clearscreen();
                }
                else if (option == "5")
                {
                    header();
                    UserInterface.addOrder();
                    clearscreen();
                }
                else if (option == "6")
                {
                    header();
                    CoffeeShop.fulfillOrders();
                    clearscreen();
                }
                else if (option == "7")
                {
                    header();
                    CoffeeShop.viewOrders();
                    clearscreen();
                }
                else if (option == "8")
                {
                    header();
                    CoffeeShop.showAmount();
                    clearscreen();
                }
            }
        }

        public static void clearscreen()
        {
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue ... !");
            Console.ReadKey();
        }
        public static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                              ///////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                              //                    Tesla's  Coffee Shop                       //");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                              ///////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
        }

    }
}
