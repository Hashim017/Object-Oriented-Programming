using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airlineSystem;
using System.IO;

namespace airlineSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int flightsCount = 0;
            List<flightRecords> flight = new List<flightRecords>();
            readData(flight, ref flightsCount);
            char option = '9';
            string username, password;

            while (true)
            {
                header();
                Console.Write("Enter Username: ");
                username = Console.ReadLine();
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (username == "Hashim" && password == "123")
                {
                    break;
                    
                }
                else
                {
                    continue;
                }
                
            }
            while(option != '0')
            {
                option = mainMenu();
                if (option == '1')
                {
                    header();
                    flight.Add(addFlight());
                    storeFlights(flight);
                    Console.WriteLine();
                    Console.WriteLine("Flight Added Successfully.");
                    clearScreen();

                }
                if (option == '2')
                {
                    updateFlight(flight);

                }
                if (option == '3')
                {
                    viewFlights(flight);

                }
                if (option == '4')
                {
                    cancelFlight(flight);

                }
                else
                {
                    continue;
                }
            }
        }

        static void clearScreen()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("      ////          $$$$$$\\  $$\\           $$\\ $$\\                            $$$$$$\\                        $$\\                                             ////");
            Console.WriteLine("      ////         $$  __$$\\ \\__|          $$ |\\__|                          $$  __$$\\                       $$ |                                            ////");
            Console.WriteLine("      ////         $$ /  $$ |$$\\  $$$$$$\\  $$ |$$\\ $$$$$$$\\   $$$$$$\\        $$ /  \\__|$$\\   $$\\  $$$$$$$\\ $$$$$$\\    $$$$$$\\  $$$$$$\\$$$$\\                  ////");
            Console.WriteLine("      ////         $$$$$$$$ |$$ |$$  __$$\\ $$ |$$ |$$  __$$\\ $$  __$$\\       \\$$$$$$\\  $$ |  $$ |$$  _____|\\_$$  _|  $$  __$$\\ $$  _$$  _$$\\                 ////");
            Console.WriteLine("      ////         $$  __$$ |$$ |$$ |  \\__|$$ |$$ |$$ |  $$ |$$$$$$$$ |       \\____$$\\ $$ |  $$ |\\$$$$$$\\    $$ |    $$$$$$$$ |$$ / $$ / $$ |                ////");
            Console.WriteLine("      ////         $$ |  $$ |$$ |$$ |      $$ |$$ |$$ |  $$ |$$   ____|      $$\\   $$ |$$ |  $$ | \\____$$\\   $$ |$$\\ $$   ____|$$ | $$ | $$ |                ////");
            Console.WriteLine("      ////         $$ |  $$ |$$ |$$ |      $$ |$$ |$$ |  $$ |\\$$$$$$$\\       \\$$$$$$  |\\$$$$$$$ |$$$$$$$  |  \\$$$$  |\\$$$$$$$\\ $$ | $$ | $$ |                ////");
            Console.WriteLine("      ////         \\__|  \\__|\\__|\\__|      \\__|\\__|\\__|  \\__| \\_______|       \\______/  \\____$$ |\\_______/    \\____/  \\_______|\\__| \\__| \\__|                ////");
            Console.WriteLine("      ////                                                                             \\$$$$$$ |                                                             ////");
            Console.WriteLine("      ////                                                                              \\______/                                                             ////");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine();
        }

        static char mainMenu()
        {
            char option;
            header();
            Console.WriteLine("1 - Add A Flight.");
            Console.WriteLine("2 - Udate Flight Time.");
            Console.WriteLine("3 - View Flights.");
            Console.WriteLine("4 - Cancel A Flight.");
            Console.WriteLine();
            Console.WriteLine("0 - To Exist Program.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            option = Char.Parse(Console.ReadLine());
            return option;
        }

        static flightRecords addFlight()
        {
            flightRecords add = new flightRecords();
            Console.Write("Enter Flight Name: ");
            add.flightName  = Console.ReadLine();
            Console.Write("Enter Flight Price: ");
            add.flightPrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Flight Time: ");
            add.flightTime = Console.ReadLine();
            return add;
        }

        static void updateFlight(List<flightRecords> flight)
        {
            header();

            string flightName, flightTime;
            int count = 0;
            flightRecords add = new flightRecords();
            Console.Write("Enter Flight Name: ");
            flightName = Console.ReadLine();
            for (int x = 0; x < flight.Count; x++)
            {
                if (flightName == flight[x].flightName)
                {
                    Console.Write("Enter New Time: ");
                    flightTime = Console.ReadLine();
                    flight[x].flightTime = flightTime;
                    Console.WriteLine();
                    Console.WriteLine("Time Updated Successfully.");
                    count++;
                    storeFlights(flight);
                    clearScreen();

                }
            }
            if (count == 0)
            {
                Console.WriteLine();
                Console.Write("Invalid Flight Name.");
                clearScreen();
            }
        }

        static void viewFlights(List<flightRecords> flight)
        {
            header();
            int num = 1;
            
            for (int x = 0; x < flight.Count; x++)
            {
                    Console.WriteLine(num + " - " + "Flight Name: " + flight[x].flightName);
                    Console.WriteLine("    Flight Price: " + flight[x].flightPrice);
                    Console.WriteLine("    Flight Time: " + flight[x].flightTime);
                    num++;
                    Console.WriteLine();
                    Console.WriteLine();
            }
            clearScreen();
        }

        static void cancelFlight(List<flightRecords> flight)
        {
            header();
            string flightName;
            int count = 0;
            int num = 1;
            for (int x = 0; x < flight.Count; x++)
            {
                    Console.WriteLine(num + " - " + "Flight Name: " + flight[x].flightName);
                    Console.WriteLine("    Flight Price: " + flight[x].flightPrice);
                    Console.WriteLine("    Flight Time: " + flight[x].flightTime);
                    num++;
                    Console.WriteLine();
                    Console.WriteLine();
            }
            Console.Write("Enter Flight Name: ");
            flightName = Console.ReadLine();
            for (int x = 0; x < flight.Count; x++)
            {
                if (flightName == flight[x].flightName)
                {
                    flight.RemoveAt(x);
                    Console.WriteLine();
                    Console.WriteLine("Flight Deleted Successfully.");
                    count++;
                    storeFlights(flight);
                    clearScreen();
                }
            }
            if (count == 0)
            {
                Console.WriteLine();
                Console.Write("Invalid Flight Name.");
                clearScreen();
            }
        }

        static string findData(string record, int field)
        {
            int comma = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }


        static void storeFlights(List<flightRecords> flight)
        {
            StreamWriter file = new StreamWriter("FlightsRecord.txt");
            for (int x = 0; x < flight.Count; x++)
            {
                    file.Write(flight[x].flightName + "," + flight[x].flightPrice + "," + flight[x].flightTime);
                    file.WriteLine();
            }
            file.Close();
        }

        static void readData(List<flightRecords> flight, ref int flightsCount)
        {
            string record = "";
            
            StreamReader file = new StreamReader("FlightsRecord.txt");
            while ((record = file.ReadLine()) != null)
            {
                flightRecords data = new flightRecords();
                data.flightName = (findData(record, 1));
                data.flightPrice = float.Parse((findData(record, 2)));
                data.flightTime = (findData(record, 3));
                flight.Insert(flightsCount, data);
                flightsCount++;
            }
            file.Close();
        }
    }
    
}
