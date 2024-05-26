using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ship_task.BL;

namespace Ship_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Ship ships = new Ship();
            string option = "9";
            while(option != "0")
            {
                header();
                option = menu();
                if(option == "1")
                {
                    header();
                    Console.WriteLine();
                    ships = addShip();
                }
                else if(option == "2")
                {
                    header();
                    Console.WriteLine();
                    bool check = viewShipPostion(ships);
                    if(check == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ship Is At: " + ships.Angles.latDegrees + "\u00b0" + ships.Angles.latMinutes + "'" + ships.Angles.latDirection + " and " + +ships.Angles.lonDegrees + "\u00b0" + ships.Angles.lonMinutes + "'" + ships.Angles.lonDirection);
                        Console.ReadKey();
                    }
                    else if(check == false)
                    {
                        Console.WriteLine();
                        Console.Write("Invalid Serial Number.");
                        Console.ReadKey();
                    }
                }
                else if(option == "3")
                {
                    header();
                    Console.WriteLine();
                    bool check = viewShipNumber(ships);
                    if(check == true)
                    {
                        Console.WriteLine();
                        Console.Write("Ship's Serial Number: " + ships.ShipNumber);
                        Console.ReadKey();
                    }
                    else if (check == false)
                    {
                        Console.WriteLine();
                        Console.Write("Invalid Ship Latitude Or Longitude");
                        Console.ReadKey();
                    }
                }
                else if (option == "4")
                {
                    header();
                    Console.WriteLine();
                    Console.Write("Enter Ship's Serial Number Whose Position You Want To Change: ");
                    string number = Console.ReadLine();
                    if (number == ships.ShipNumber)
                    {
                        ships = changePosition(ships);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Invalid Serial Number.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks For Using My System.");
            Console.ReadKey();
        }
        static string menu()
        {
            string option = "";
            Console.WriteLine("Press One Of The Following Keys: ");
            Console.WriteLine();
            Console.WriteLine("1 - Add Ship.");
            Console.WriteLine("2 - View Ship Position.");
            Console.WriteLine("3 - View Ship Serial Number.");
            Console.WriteLine("4 - Change Ship Position.");
            Console.WriteLine("0 - Exit.");
            Console.Write("Your Option: ");
           option = Console.ReadLine();
            return option;
        }

        static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("////   -------------------------    SHIP NAVIGATION SYSTEM    -------------------------   ////");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
        }

        static Ship addShip()
        {
            Console.Write("Enter Ship Number: ");
            string number = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude's Degree: ");
            int latdegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Minutes: ");
            float latminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Direction: ");
            char latdirection = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude's Degree: ");
            int londegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Minutes: ");
            float lonminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Direction: ");
            char londirection = char.Parse(Console.ReadLine());

            Angle angle = new Angle(latdegrees, latminutes, latdirection, londegrees, lonminutes, londirection);
            Ship ship = new Ship(number, angle);
            return ship;
        }

        static bool viewShipPostion(Ship ships)
        {
            bool check = false;
            Console.Write("Enter Ship Serial Number To Find Its Position: ");
            string a = Console.ReadLine();
            if(a == ships.ShipNumber)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        static bool viewShipNumber(Ship ships)
        {
            bool check = false;
            string latitude = ships.Angles.latDegrees.ToString() + "*" + ships.Angles.latMinutes.ToString() + "'" + ships.Angles.latDirection;
            string longitude = ships.Angles.lonDegrees.ToString() + "*" + ships.Angles.lonMinutes.ToString() + "'" + ships.Angles.lonDirection;
            Console.Write("Enter Ship Latitude (use * for degrees): ");
            string a = Console.ReadLine();
            Console.Write("Enter Ship Longitude (use * for degrees): ");
            string b = Console.ReadLine();
            if(a == latitude)
            {
                if(b == longitude)
                {
                    check = true;
                }
            }
            return check;
        }

        static Ship changePosition(Ship ships)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude's Degree: ");
            int latdegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Minutes: ");
            float latminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Direction: ");
            char latdirection = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude's Degree: ");
            int londegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Minutes: ");
            float lonminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Direction: ");
            char londirection = char.Parse(Console.ReadLine());
            ships.Angles.changeAngle(latdegrees, latminutes, latdirection, londegrees, lonminutes, londirection);
            return ships;
        }
    }
}
