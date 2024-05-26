using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                { 
                    viewStudent(s, count);
                }

                else if (option == '3')
                { 
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                Console.WriteLine("Invalid Choice");
                }
        }  while (option != '4');
              Console.WriteLine("Press Enter to Exit..");
              Console.Read();

        }

    static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press One Of The Following Keys ...");
            Console.WriteLine();
            Console.WriteLine("1 - For Adding a Student. ");
            Console.WriteLine("2 - For View Student. ");
            Console.WriteLine("3 - For Top three students. ");
            Console.WriteLine("4 - To exit. ");
            Console.WriteLine();
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static students addStudent()
        {
            Console.Clear();
            students s1 = new students();
            Console.Write("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Roll No: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.Write("Is Hostelide (y || n): ");
            s1.isHostelide = char.Parse(Console.ReadLine());
            return s1;
        }

        static void viewStudent(students[] s, int count)
        {
            Console.WriteLine();
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} Ishostelide: {4}", s[x].name, s[x].roll_no, s[x].cgpa, s[x].department, s[x].isHostelide);
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();
        }

        static void topStudent(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present");
            }

            else if (count == 1)
            {
                viewStudent(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 3);
            }
        }

        static int largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int x = start; x < end; x++)
            {
                if (large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }

    }


}
