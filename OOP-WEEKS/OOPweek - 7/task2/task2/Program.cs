using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static List<FireTrucks> trucks = new List<FireTrucks>();
        static void Main(string[] args)
        {
            int option = -1;
            while(option != 3)
            {
                header();
                option = menu();
                if (option == 1)
                {
                    header();
                    trucks.Add(firetruck());
                    Console.WriteLine();
                    Console.WriteLine("Truck Added Successfully ... !");
                    Console.ReadKey();
                }
                else if(option == 2)
                {
                    header();
                    scheduleTruck();
                }
            }
        }
        public static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                     //////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                     //                        Fire Department System                        //");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                     //////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public static int menu()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine();
            Console.WriteLine("1 - Add a Truck.");
            Console.WriteLine("2 - Schedule Truck for Fighting Oil.");
            Console.WriteLine("3 - Exit.");
            Console.WriteLine();
            Console.Write("Your Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static FireTrucks firetruck()
        {
            Console.Write("Enter ladder length (In meters): ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter ladder colour: ");
            string clr = Console.ReadLine();
            Console.Write("Enter driver name: ");
            string name = Console.ReadLine();
            Console.Write("Enter driver age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Does truck has a hosepipe(yes/no): ");
            string yn = Console.ReadLine();
            if(yn == "yes")
            {
                Console.WriteLine("");
            }
            FireTrucks truck = new FireTrucks(length, clr, name, age);
            return truck;
        }

        public static void scheduleTruck()
        {
            int num = 1;
            Console.WriteLine();
            for(int x= 0; x < trucks.Count; x++)
            {
                Console.WriteLine(num + " - " + "Fire Truck");
                Console.WriteLine( "    " + "Fire Truck Ladder Length: " + trucks[x].ladder.SpecificLength);
                num++;
                Console.WriteLine();
            }
            Console.Write("Select Your Truck Number: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            int numm = 1;
            for (int x = 0; x < trucks.Count; x++)
            {
                Console.WriteLine(numm + " - " + "Fire Truck Driver");
                Console.WriteLine("    " + "Fire Truck Driver Name: " + trucks[x].firefighter.Name);
                numm++;
                Console.WriteLine();
            }

            Console.Write("Select Your Truck Driver Name: ");
            string nameDriver = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Truck Scheduled Successfully .... !");
            Console.ReadKey();
        }
    }  
}
