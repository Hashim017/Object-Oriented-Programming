using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3.BL;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            List<Product> products = new List<Product>();
            Customer customers = new Customer();
            string option = "9";
            while(option != "0")
            {
                Console.Clear();
                option = menu();
                if (option == "1")
                {
                    products.Add(addProduct());
                }
                else if (option == "2")
                {
                    customers = (addCustomer());
                }
                else if (option == "3")
                {
                    Console.WriteLine();
                    Console.Write("Enter Your Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    if (name == customers.CustomerName)
                    {
                        showProducts(products);
                        purchaseProduct(products, customers);
                    }
                    else
                    {
                        Console.WriteLine("Name Not Available, Kindly Add Your Details First.");
                        Console.ReadKey();
                    }
                }
                else if(option == "4")
                {
                    Console.WriteLine();
                    Console.Write("Enter Your Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    if (name == customers.CustomerName)
                    {
                        viewPurchasedProducts(customers);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Name Not Available, Kindly Add Your Details First.");
                        Console.ReadKey();
                    }
                }
                else if (option == "5")
                {
                    Console.WriteLine();
                    Console.Write("Enter Your Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    if (name == customers.CustomerName)
                    {
                        viewPurchasedProducts(customers);
                        Console.WriteLine();
                        float tax = customers.calculateTax();
                        Console.Write("Total Tax Of Purchased Products: " + tax + " $");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Name Not Available, Kindly Add Your Details First.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        static string menu()
        {
            Console.WriteLine("Select One Of The Following Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - Add Product.");
            Console.WriteLine("2 - Add Your Details.");
            Console.WriteLine("3 - Purchase Product.");
            Console.WriteLine("4 - View Purchase Products.");
            Console.WriteLine("5 - Calculate Tax Of All Purchased Products.");
            Console.WriteLine("0 - Exit.");
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        static Product addProduct()
        {
            Console.WriteLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Product Price (In Dollars): ");
            int price = int.Parse(Console.ReadLine());
            Product products = new Product(name, category, price);
            return products;
        }

        static Customer addCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("Kindly Give Your Information.");
            Console.WriteLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Contact: ");
            string contact = Console.ReadLine();
            Customer customers = new Customer(name, address, contact);
            return customers;
        }

        static void showProducts(List<Product> products)
        {
            Console.WriteLine();
            for(int x = 0; x < products.Count; x++)
            {
                int num = 1;
                Console.WriteLine(num + " - " + "Product Name: " + products[x].ProductName);
                Console.WriteLine("    " + "Product Category: " + products[x].ProductCategory);
                Console.WriteLine("    " + "Product Price: " + products[x].ProductPrice + " $");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void purchaseProduct(List<Product> products, Customer customers)
        {
            Console.WriteLine();
            Console.Write("Enter Name Of Product: ");
            string pName = Console.ReadLine();
            int count = 0;
            for(int x = 0; x < products.Count; x++)
            {
                if(pName == products[x].ProductName)
                {
                    customers.addProduct(products[x]);
                    Console.WriteLine();
                    count++;
                    Console.WriteLine("Product Purchased Successfully.");
                    Console.ReadKey();
                    break;
                }
            }
            if (count == 0)
            {
                Console.Write("Invalid Name.");
                Console.ReadKey();
            }
        }

        static void viewPurchasedProducts(Customer customers)
        {
            Console.WriteLine();
            List<Product> products = new List<Product>();
            products = customers.getAllProducts();
                for (int x = 0; x < products.Count; x++)
                {
                    int num = 1;
                    Console.WriteLine(num + " - " + "Product Name: " + products[x].ProductName);
                    Console.WriteLine("    " + "Product Category: " + products[x].ProductCategory);
                    Console.WriteLine("    " + "Product Price: " + products[x].ProductPrice + " $");
                    Console.WriteLine();
                }
        }

    }
}
