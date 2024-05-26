using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD___3__App_;
using System.IO;
using System.Threading;

namespace PD___3__App_
{
    class Program
    {

        static void Main(string[] args)
        {
            int flightsCount = 0;
            int userCount = 0;
            flightrecords[] flight = new flightrecords[10];
            userRecords[] user = new userRecords[10];
            readData(flight, ref flightsCount, user, ref userCount);
            string option = "9";
            string username, password;


            while (option != "0")
            {
                option = mainMenu();
                if (option == "1")
                {
                    header();
                    flight[flightsCount] = addFlight();
                    flightsCount++;
                    storeFlights(flight, flightsCount);
                    Console.WriteLine();
                    Console.WriteLine("Flight Added Successfully.");
                    clearScreen();

                }
                if (option == "2")
                {
                    header();
                    updateFlight(flight, flightsCount);
                }
                if (option == "3")
                {
                    header();
                    viewFlights(flight, flightsCount);
                    clearScreen();

                }
                if (option == "4")
                {
                    header();
                    addTickets(flight, flightsCount);

                }
                if (option == "5")
                {
                    header();
                    cancelFlight(flight, flightsCount);

                }
                if (option == "6")
                {
                    header();
                    user[userCount] = addUser();
                    userCount++;
                    storeUsers(user, userCount);
                    Console.WriteLine();
                    Console.WriteLine("User Added Successfully.");
                    clearScreen();

                }
                if (option == "7")
                {
                    header();
                    viewUsers(user, userCount);
                    clearScreen();
                }
                if (option == "8")
                {
                    header();
                    removeUser(user, userCount);

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

        static string mainMenu()
        {
            string option;
            header();
            Console.WriteLine("1 - Add A Flight.");
            Console.WriteLine("2 - Udate Flight Time.");
            Console.WriteLine("3 - View Flights.");
            Console.WriteLine("4 - Add Tickets.");
            Console.WriteLine("5 - Cancel A Flight.");
            Console.WriteLine("6 - Add User.");
            Console.WriteLine("7 - View Users.");
            Console.WriteLine("8 - Remove User.");
            Console.WriteLine();
            Console.WriteLine("0 - To Exist Program.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            option =Console.ReadLine();
            return option;
        }

        static flightrecords addFlight()
        {
            string name, time;
            int price, quantity;
            Console.Write("Enter Flight Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Flight Price (In Dollars): ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Enter Flight Time: ");
            time = Console.ReadLine();
            Console.Write("Enter Tickets Quantity: ");
            quantity = int.Parse(Console.ReadLine());
            flightrecords s = new flightrecords(name, price, time, quantity);
            return s;
        }

        static void updateFlight(flightrecords[] flight, int flightsCount)
        {
            viewFlights(flight, flightsCount);
            string flightName, time;
            int count = 0;
            Console.Write("Enter Flight Name: ");
            flightName = Console.ReadLine();
            for (int x = 0; x < flightsCount; x++)
            {
                if (flightName == flight[x].flightName)
                {
                    Console.Write("Enter New Time: ");
                    time = Console.ReadLine();
                    flight[x].updateTime(time);
                    Console.WriteLine();
                    Console.WriteLine("Time Updated Successfully.");
                    count++;
                    storeFlights(flight, flightsCount);
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

        static void viewFlights(flightrecords[] flight, int flightCount)
        {
            Console.WriteLine();
            int num = 1;
            for (int x = 0; x < flightCount; x++)
            {
                if (flight[x].flightName != "!")
                {
                    Console.WriteLine(num + " - " + "Flight Name: " + flight[x].flightName);
                    Console.WriteLine("    " + "Flight Price: " + flight[x].flightPrice + "$");
                    Console.WriteLine("    " + "Flight Time: " + flight[x].flightTime);
                    Console.WriteLine("    " + "Tickets Quantity: " + flight[x].flightQuantity);
                    Console.WriteLine();
                    num++;
                }
            }
        }

        static void addTickets(flightrecords[] flight, int flightsCount)
        {
            viewFlights(flight, flightsCount);
            string name;
            int tickets;
            int count = 0;
            Console.Write("Enter Flight Name: ");
            name = Console.ReadLine();
            for (int x = 0; x < flightsCount; x++)
            {
                if (name == flight[x].flightName)
                {
                    Console.Write("Enter Number Of Tickets You Want To Add: ");
                    tickets = int.Parse(Console.ReadLine());
                    flight[x].addTickets(tickets);
                    Console.WriteLine();
                    Console.WriteLine("Tickets Added Successfully.");
                    count++;
                    storeFlights(flight, flightsCount);
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

        static void cancelFlight(flightrecords[] flight, int flightsCount)
        {
            viewFlights(flight, flightsCount);
            string name;
            int count = 0;
            Console.Write("Enter Flight Name: ");
            name = Console.ReadLine();
            for (int x = 0; x < flightsCount; x++)
            {
                if (name == flight[x].flightName)
                {
                    flight[x].cancelFlight();
                    Console.WriteLine();
                    Console.WriteLine("Flight Deleted Successfully.");
                    count++;
                    storeFlights(flight, flightsCount);
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

        static userRecords addUser()
        {
            string username, password;
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            userRecords s = new userRecords(username, password);
            return s;
        }

        static void viewUsers(userRecords[] user, int userCount)
        {
            Console.WriteLine();
            int num = 1;
            for (int x = 0; x < userCount; x++)
            {
                if (user[x].username != "!")
                {
                    Console.WriteLine(num + " - " + "Userame: " + user[x].username);
                    Console.WriteLine("    " + "Password: " + user[x].password);
                    Console.WriteLine();
                    num++;
                }
            }
        }

        static void removeUser(userRecords[] user, int userCount)
        {
            viewUsers(user, userCount);
            string name;
            int count = 0;
            Console.Write("Enter Username: ");
            name = Console.ReadLine();
            for (int x = 0; x < userCount; x++)
            {
                if (name == user[x].username)
                {
                    user[x].removeUser();
                    Console.WriteLine();
                    Console.WriteLine("User Removed Successfully.");
                    count++;
                    storeUsers(user, userCount);
                    clearScreen();
                }
            }
            if (count == 0)
            {
                Console.WriteLine();
                Console.Write("Invalid Username.");
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


        static void storeFlights(flightrecords[] flight, int flightsCount)
        {
            StreamWriter file = new StreamWriter("FlightsRecord.txt");
            for (int x = 0; x < flightsCount; x++)
            {
                if (flight[x].flightName != "!")
                {
                    file.Write(flight[x].flightName + "," + flight[x].flightPrice + "," + flight[x].flightTime + "," + flight[x].flightQuantity);
                    file.WriteLine();
                }
            }
            file.Close();
        }

        static void storeUsers(userRecords[] user, int userCount)
        {
            StreamWriter file = new StreamWriter("UserRecord.txt");
            for (int x = 0; x < userCount; x++)
            {
                if (user[x].username != "!")
                {
                    file.Write(user[x].username + "," + user[x].password);
                    file.WriteLine();
                }
            }
            file.Close();
        }

        static void readData(flightrecords[] flight, ref int flightsCount, userRecords[] user, ref int userCount)
        {
            string record = "";

            StreamReader file = new StreamReader("FlightsRecord.txt");
            while ((record = file.ReadLine()) != null)
            {
                string flightName = (findData(record, 1));
                int flightPrice = int.Parse((findData(record, 2)));
                string flightTime = (findData(record, 3));
                int flightQuantity = int.Parse((findData(record, 4)));
                flight[flightsCount] = new flightrecords(flightName, flightPrice, flightTime, flightQuantity);
                flightsCount++;
            }
            file.Close();

            StreamReader data = new StreamReader("UserRecord.txt");
            while ((record = data.ReadLine()) != null)
            {
                string username = (findData(record, 1));
                string password = (findData(record, 2));
                user[userCount] = new userRecords(username, password);
                userCount++;
            }
            data.Close();
        }

    }
}
