using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class CoffeeShop
    {
        public string ShopName;
        public static List<MenuItem> menuitems = new List<MenuItem>();
        public static List<string> orders = new List<string>();

        public static void addItem(MenuItem newItem)
        {
            menuitems.Add(newItem);
        }

        public static MenuItem returnCheapestItem()
        {
            int lowestPrice = 100000;
            foreach (MenuItem items in menuitems)
            {
                if (items.ItemPrice < lowestPrice)
                {
                    lowestPrice = items.ItemPrice;
                }
            }
            MenuItem item = new MenuItem();
            foreach (MenuItem items in menuitems)
            {
                if (items.ItemPrice == lowestPrice)
                {
                    item = items;
                }
            }
            return item;
        }

        public static void fulfillOrders()
        {
            Console.WriteLine();
            for (int x = 0; x < orders.Count; x++)
            {
                Console.WriteLine("The " + orders[x] + " is ready ... !");
            }
            orders.Clear();
            Console.WriteLine();
            Console.WriteLine("All Orders Have Been Fulfilled .. !");
        }

        public static void viewOrders()
        {
            int num = 1;
            Console.WriteLine();
            for (int x = 0; x < orders.Count; x++)
            {
                Console.WriteLine(num + " - " + orders[x]);
                num++;
                Console.WriteLine();
            }
        }

        public static void showAmount()
        {
            int amount = 0;
            for (int x = 0; x < orders.Count; x++)
            {
                for (int y = 0; y < menuitems.Count; y++)
                {
                    if (orders[x] == menuitems[y].ItemName)
                        amount = amount + menuitems[y].ItemPrice;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total Payable Amount Is: " + amount + " Rs");
        }

        public static void displayCheapestItem()
        {
            Console.WriteLine();
            Console.WriteLine("Cheapest Item ... !");
            Console.WriteLine();
            MenuItem item = CoffeeShop.returnCheapestItem();
            Console.WriteLine("Item Name: " + item.ItemName);
            Console.WriteLine("Item Type: " + item.ItemType);
            Console.WriteLine("Item Price: " + item.ItemPrice + " Rs");
        }
    }
}
