using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Products[] s = new Products[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addProducts();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewProducts(s, count);
                }
                else if (option == '3')
                {
                    totalWorth(s, count);
                }

            } while (option  != '4');
        }

        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press One Of The Following Keys ...");
            Console.WriteLine();
            Console.WriteLine("1 - For Adding a Product. ");
            Console.WriteLine("2 - For View Products. ");
            Console.WriteLine("3 - For Total Store Worth. ");
            Console.WriteLine("4 - To exit. ");
            Console.WriteLine();
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Products addProducts()
        {
            Console.Clear();
            Products s1 = new Products();
            Console.Write("Enter Product ID: ");
            s1.productID = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            s1.productName = (Console.ReadLine());
            Console.Write("Enter Product Price: ");
            s1.productPrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Product Category: ");
            s1.productCategory = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            s1.brandName = (Console.ReadLine());
            Console.Write("Enter Country: ");
            s1.country = (Console.ReadLine());
            return s1;
        }

        static void viewProducts(Products[] s, int count)
        {
            Console.WriteLine();
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Product ID: {0} Product Name: {1} Product Price: {2} Product Category: {3} Brand Name: {4} Country: {5}", s[x].productID, s[x].productName, s[x].productPrice, s[x].productCategory, s[x].brandName, s[x].country);
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();
        }

        static void totalWorth(Products[] s, int count)
        {
            float largest = 0;
            for(int x = 0; x < count; x++)
            {
                largest = largest + s[x].productPrice;
            }
            Console.WriteLine();
            Console.WriteLine("Total Store Worth Is: " + largest);
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();
        }
    }
}
