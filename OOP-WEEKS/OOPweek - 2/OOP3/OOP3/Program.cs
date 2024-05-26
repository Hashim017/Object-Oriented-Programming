using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3;
using System.IO;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Credentials[] s = new Credentials[10];
            char option;
            int count = 0;
            readData(s, ref count);

            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addUser();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewUsers(s, count);
                }

                else if (option == '3')
                {
                    storeData(s, count);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (option != '3');
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press One Of The Following Keys ...");
            Console.WriteLine();
            Console.WriteLine("1 - For Adding a User. ");
            Console.WriteLine("2 - For View Users. ");
            Console.WriteLine("3 - To exit. ");
            Console.WriteLine();
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static Credentials addUser()
        {
            Console.Clear();
            Credentials s1 = new Credentials();
            Console.Write("Enter Username: ");
            s1.username = Console.ReadLine();
            Console.Write("Enter Password: ");
            s1.password = Console.ReadLine();
            return s1;
        }

        static void viewUsers(Credentials[] s, int count)
        {
            Console.WriteLine();
            int num = 1;
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine(num + " - " + "Username: " + s[x].username);
                Console.WriteLine("    Password: " + s[x].password);
                num++;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();
        }

        static void storeData(Credentials[] s, int count)
        {
            StreamWriter file = new StreamWriter("Credentials.txt", true);
            for (int x = 0; x < count; x++)
            {
                file.Write(s[x].username + "," + s[x].password);
                file.WriteLine();
            }
            file.Flush();
            file.Close();
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

        static void readData(Credentials[] s, ref int count)
        {
            string record = "";
            StreamReader file = new StreamReader("Credentials.txt");
            while ((record = file.ReadLine()) != null)
            {
                Credentials credential = new Credentials();
                credential.username = findData(record, 1);
                credential.password = findData(record, 2);
                s[count] = credential;
                count++;
            }
            file.Close();
        }
    }
}

