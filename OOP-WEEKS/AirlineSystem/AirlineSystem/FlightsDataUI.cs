using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class FlightsDataUI
    {
        public static FlightsDataBL takeInput()
        {
            Console.Write("Enter Flight Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Flight Time: ");
            string time = Console.ReadLine();
            Console.Write("Enter Flight Route: ");
            string route = Console.ReadLine();
            Console.Write("Enter Flight Price (In Dollars): ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Tickets Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            FlightsDataBL flight = new FlightsDataBL(name, time, route, price, quantity);
            return flight;
        }

        public static void displayFlights()
        {
            int num = 1, col = 32;
            foreach(var f in FlightsDataDL.Flights)
            {
                if(num == 1)
                {
                    Console.SetCursorPosition(0, col - 2);
                    Console.WriteLine("    Flight Name\t\t" + "Flight Time\t\t" + "Flight Route\t\t" + "Flight Price\t\t" + "Tickets Quantity");
                }
                Console.SetCursorPosition(0, col);
                Console.WriteLine(num + " - " + f.FlightName);
                Console.SetCursorPosition(24, col);
                Console.WriteLine(f.FlightTime);
                Console.SetCursorPosition(48, col);
                Console.WriteLine(f.FlightRoute);
                Console.SetCursorPosition(72, col);
                Console.WriteLine(f.FlightPrice);
                Console.SetCursorPosition(96, col);
                Console.WriteLine(f.FlightTickets);
                col = col + 2;
                num++;
            }
            col = 32;
        }

        public static void addedFlight()
        {
            Console.WriteLine();
            Console.WriteLine("Flight Added Succesfully ... !");
        }

        public static int selectNumber()
        {
            Console.WriteLine();
            Console.Write("Select Number of Flight: ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static void inValidFlightNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Number ... !");
        }

        public static void dispalySpecificFlight(FlightsDataBL flight)
        {
            foreach (var f in FlightsDataDL.Flights)
            {
                if(f.FlightName == flight.FlightName)
                {
                    Console.SetCursorPosition(0, 30);
                    Console.WriteLine("Flight Name\t\t" + "Flight Time\t\t" + "Flight Route\t\t" + "Flight Price\t\t" + "Tickets Quantity");
                    Console.SetCursorPosition(0, 32);
                    Console.WriteLine(f.FlightName);
                    Console.SetCursorPosition(24, 32);
                    Console.WriteLine(f.FlightTime);
                    Console.SetCursorPosition(48, 32);
                    Console.WriteLine(f.FlightRoute);
                    Console.SetCursorPosition(72, 32);
                    Console.WriteLine(f.FlightPrice);
                    Console.SetCursorPosition(96, 32);
                    Console.WriteLine(f.FlightTickets);
                }
            }
        }

        public static double enterPrice()
        {
            Console.WriteLine();
            Console.Write("Enter New Price: ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }

        public static void updatedPrice()
        {
            Console.WriteLine();
            Console.WriteLine("Price Updated Successfully ... !");
        }

        public static string enterTime()
        {
            Console.WriteLine();
            Console.Write("Enter New Time: ");
            string time = Console.ReadLine();
            return time;
        }

        public static void updatedTime()
        {
            Console.WriteLine();
            Console.WriteLine("Time Updated Successfully ... !");
        }

        public static string enterRoute()
        {
            Console.WriteLine();
            Console.Write("Enter New Route: ");
            string time = Console.ReadLine();
            return time;
        }

        public static void updatedRoute()
        {
            Console.WriteLine();
            Console.WriteLine("Route Updated Successfully ... !");
        }

        public static void cancledFlight()
        {
            Console.WriteLine();
            Console.WriteLine("Flight Canceled Successfully ... !");
        }

        public static int enterQuantity()
        {
            Console.WriteLine();
            Console.Write("Enter Number of Tickets You Want To Add: ");
            int quantity = int.Parse(Console.ReadLine());
            return quantity;
        }

        public static void updatedQuantity()
        {
            Console.WriteLine();
            Console.WriteLine("Tickets Added Successfully ... !");
        }
    }
}

