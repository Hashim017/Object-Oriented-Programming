﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class MenuUI
    {
        public static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                               /////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                               //                        UAMS                             //");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                               /////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public static void clearScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static int Menu()
        {
            header();
            int option;
            Console.WriteLine("Select One Of The Following Option ... ");
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.WriteLine();
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
