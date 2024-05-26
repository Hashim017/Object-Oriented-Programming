using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    class Program
    {
        
        // Username = "Hashim"
        // Password = "123"

        static void Main(string[] args)
        {
            string username;
            string password;
            while (true)
            {
                header();
                Console.Write("Enter Username: ");
                username = Console.ReadLine();
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
                checkCredentials(username, password);
                
            }
        }

        static void checkCredentials(string username, string password)
        {
           
            if (username == "Hashim" && password == "123")
            {
                Console.WriteLine();
                menu();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Credentials Does Not Exists.");
                Console.WriteLine();

            }
        }

        static void menu()
        {
            string[] flightNames = new string[100];
            string[] flightPrices = new string[100];
            string[] flightTimes = new string[100];
            int flightsCount = 0;
            string flightName, flightTime, flightPrice, option = "-1";

            // Read Data From File.

            string record = "";
            StreamReader file = new StreamReader("FlightsRecord.txt");
            while ((record = file.ReadLine()) != null)
            {
                flightNames[flightsCount] = (findData(record, 1));
                flightPrices[flightsCount] = findData(record, 2);
                flightTimes[flightsCount] = findData(record, 3);
                flightsCount++;
            }
            file.Close();
           
            while (option != "0")
            {
                header();
                Console.WriteLine("1 - Add A Flight.");
                Console.WriteLine("2 - Udate Flight Time.");
                Console.WriteLine("3 - View Flights.");
                Console.WriteLine("4 - Cancel A Flight.");
                Console.WriteLine();
                Console.WriteLine("0 - To Exist Program.");
                Console.WriteLine();
                Console.Write("Your Option: ");
                option = Console.ReadLine();

                if(option == "1")
                {
                    header();
                    
                    Console.Write("Enter Flight Name: ");
                    flightName = Console.ReadLine();
                    Console.Write("Enter Flight Price: ");
                    flightPrice = Console.ReadLine();
                    Console.Write("Enter Flight Time: ");
                    flightTime = Console.ReadLine();

                    flightNames[flightsCount] = flightName;
                    flightPrices[flightsCount] = flightPrice;
                    flightTimes[flightsCount] = flightTime;
                    flightsCount++;
                    storeFlights(flightNames, flightPrices, flightTimes, flightsCount);

                    Console.WriteLine();
                    Console.WriteLine("Flight Added Successfully.");
                    clearScreen();
                }
                if (option == "2")
                {
                    header();
                    int count = 0;
                    int num = 1;
                    for (int x = 0; x < flightsCount; x++)
                    {
                        if (flightNames[x] != "!")
                        {
                            Console.WriteLine(num + " - " + "Flight name: " + flightNames[x]);
                            Console.WriteLine("    Flight Price: " + flightPrices[x]);
                            Console.WriteLine("    Flight name: " + flightTimes[x]);
                            num++;
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    Console.Write("Enter Flight Name: ");
                    flightName = Console.ReadLine();
                    for(int x = 0; x < flightsCount; x++)
                    {
                        if(flightName == flightNames[x])
                        {
                            Console.Write("Enter New Time: ");
                            flightTime = Console.ReadLine();

                            flightTimes[x] = flightTime;
                            Console.WriteLine();
                            Console.WriteLine("Time Updated Successfully.");
                            count++;
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
                if (option == "3")
                {
                    header();
                    int num = 1;
                    for(int x = 0; x < flightsCount; x++)
                    {
                        if (flightNames[x] != "!")
                        {
                            Console.WriteLine(num + " - " + "Flight name: " + flightNames[x]);
                            Console.WriteLine("    Flight Price: " + flightPrices[x]);
                            Console.WriteLine("    Flight name: " + flightTimes[x]);
                            num++;
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    clearScreen();
                }
                if (option == "4")
                {
                    header();
                    int count = 0;
                    int num = 1;
                    for (int x = 0; x < flightsCount; x++)
                    {
                        if (flightNames[x] != "!")
                        {
                            Console.WriteLine(num + " - " + "Flight name: " + flightNames[x]);
                            Console.WriteLine("    Flight Price: " + flightPrices[x]);
                            Console.WriteLine("    Flight name: " + flightTimes[x]);
                            num++;
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    Console.Write("Enter Flight Name: ");
                    flightName = Console.ReadLine();
                    for (int x = 0; x < flightsCount; x++)
                    {
                        if (flightName == flightNames[x])
                        {
                            flightNames[x] = "!";
                            Console.WriteLine();
                            Console.WriteLine("Flight Deleted Successfully.");
                            count++;
                            storeFlights(flightNames, flightPrices, flightTimes, flightsCount);
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

                else
                {
                    continue;
                }
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


        static void storeFlights(string[] flightNames, string[] flightPrices, string[] flightTimes, int flightsCount)
        {
            StreamWriter file = new StreamWriter("FlightsRecord.txt");
            for (int x = 0; x < flightsCount; x++)
            {
                if (flightNames[x] != "!")
                {
                    file.Write(flightNames[x] + "," + flightPrices[x] + "," + flightTimes[x]);
                    file.WriteLine();
                }
            }
            file.Close();
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

        static void clearScreen()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}