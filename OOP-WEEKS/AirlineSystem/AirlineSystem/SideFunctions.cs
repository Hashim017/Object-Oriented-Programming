using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class SideFunctions
    {
        public static void clearScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("                                                                       Press Any Key To Continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void exit()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Thanks For Using Airline Management System");
        }

        public static void getHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Follow the following instructions.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Use the Numeric Keys To Select The Required Option.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("For more instructions follow us on instagram: 'chhashim17'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Contact: 'chhashimi34@gmail.com'");
        }
    }
}
