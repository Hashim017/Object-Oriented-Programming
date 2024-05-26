using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class MenusUI
    {
        public static string mainMenu()
        {
            // Display the main menu options
            Console.WriteLine("Select One Of The Following Options:\n");
            Console.WriteLine();
            Console.WriteLine("1 - For Admin Sign In.");
            Console.WriteLine("2 - For Customer.");
            Console.WriteLine("3 - Exit.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static string adminMenu()
        {
            // Display the admin menu options
            Console.WriteLine("Select One Of The Following Options:\n");
            Console.WriteLine();
            Console.WriteLine("1 - To Add Flight.");
            Console.WriteLine("2 - To Update the Prices.");
            Console.WriteLine("3 - To View the Flights.");
            Console.WriteLine("4 - To Update Timings of Flights.");
            Console.WriteLine("5 - To Cancel the Flights.");
            Console.WriteLine("6 - To Update Flights Routes.");
            Console.WriteLine("7 - To Update the Tickets Quantity.");
            Console.WriteLine("8 - To Add Another Admin.");
            Console.WriteLine("9 - To View Either Flight is Full or Not After Sale of Tickets.");
            Console.WriteLine("0 - Exit.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static string userSign()
        {
            // Display the sigin in sign up menu for user
            Console.WriteLine("Select One Of The Following Options:\n");
            Console.WriteLine();
            Console.WriteLine("1 - For Sign In.");
            Console.WriteLine("2 - For Sign Up.");
            Console.WriteLine("3 - Return To Main Menu.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static string userMenu()
        {
            // Display the user menu options
            Console.WriteLine("Select One Of The Following Options:\n");
            Console.WriteLine();
            Console.WriteLine("1 - To Find a Flight.");
            Console.WriteLine("2 - To View Bought Tickets.");
            Console.WriteLine("3 - To Refund Tickets.");
            Console.WriteLine("4 - To Get Help.");
            Console.WriteLine("5 - Exit.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

    }
}
