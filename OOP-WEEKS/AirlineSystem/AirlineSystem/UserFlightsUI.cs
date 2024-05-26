using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class UserFlightsUI
    {
        public static int enterTickets()
        {
            Console.WriteLine();
            Console.Write("Enter Number of Tickets You Want To Buy: ");
            int tickets = int.Parse(Console.ReadLine());
            return tickets;
        }

        public static int enterRefundTickets()
        {
            Console.WriteLine();
            Console.Write("Enter Number of Tickets You Want To Refund: ");
            int tickets = int.Parse(Console.ReadLine());
            return tickets;
        }

        public static void displayFlights()
        {
            int num = 1, col = 26;
            foreach (var f in FlightsDataDL.Flights)
            {
                if (num == 1)
                {
                    Console.SetCursorPosition(0, col - 2);
                    Console.WriteLine("    Flight Name\t\t" + "Flight Time\t\t" + "Flight Route\t\t" + "Flight Price\t\t");
                }
                Console.SetCursorPosition(0, col);
                Console.WriteLine(num + " - " + f.FlightName);
                Console.SetCursorPosition(24, col);
                Console.WriteLine(f.FlightTime);
                Console.SetCursorPosition(48, col);
                Console.WriteLine(f.FlightRoute);
                Console.SetCursorPosition(72, col);
                Console.WriteLine(f.FlightPrice);
                col = col + 2;
                num++;
            }
            col = 32;
        }

        public static void dispalySpecificFlight(UserFlightsBL flight)
        {
            foreach (var f in FlightsDataDL.Flights)
            {
                if (f.FlightName == flight.FlightName)
                {
                    Console.SetCursorPosition(0, 30);
                    Console.WriteLine("Flight Name\t\t" + "Flight Time\t\t" + "Flight Route\t\t" + "Flight Price\t\t" );
                    Console.SetCursorPosition(0, 32);
                    Console.WriteLine(f.FlightName);
                    Console.SetCursorPosition(24, 32);
                    Console.WriteLine(f.FlightTime);
                    Console.SetCursorPosition(48, 32);
                    Console.WriteLine(f.FlightRoute);
                    Console.SetCursorPosition(72, 32);
                    Console.WriteLine(f.FlightPrice);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tickets Quantity: " + flight.Tickets);
        }

        public static string confirmTickets()
        {
            Console.WriteLine();
            Console.WriteLine("Press 1 to Confirm or Any Other Key To Cancel.");
            Console.Write("Your Option: ");
            string confirm = Console.ReadLine();
            return confirm;
        }

        public static void thanks()
        {
            Console.WriteLine();
            Console.WriteLine("Thanks For Using Our System ... :)");
        }

        public static void thanksOnBought(int tickets)
        {
            if(tickets == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Ticket Bought Successfully Have a Safe Journey ... :)");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Tickets Bought Successfully Have a Safe Journey ... :)");
            }
        }

        public static void thanksOnRefund(int tickets)
        {
            if (tickets == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Ticket Refunded Successfully Have a Safe Journey ... :)");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Tickets Refunded Successfully Have a Safe Journey ... :)");
            }
        }

        public static void outOfOrder(FlightsDataBL flight)
        {
            Console.WriteLine();
            Console.WriteLine("Sorry Available Tickets Are: " + flight.FlightTickets);
        }

        public static void displayBoughtFlights()
        {
            int num = 1, col = 27;
            foreach (var f in UserFlightsDL.UserFlights)
            {
                if (num == 1)
                {
                    Console.SetCursorPosition(0, col - 2);
                    Console.WriteLine("    Flight Name\t\t" + "Flight Time\t\t" + "Flight Route\t\t" + "Flight Price\t\t" + "Tickets Bought");
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
                Console.WriteLine(f.Tickets);
                col = col + 2;
                num++;
            }
            col = 32;
        }

        public static void invalidBoughtTickets(int boughtTickets)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Input, Your Bought Tickets Are: " + boughtTickets);
        }
    }
}
