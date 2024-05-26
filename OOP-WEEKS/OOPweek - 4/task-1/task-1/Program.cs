using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string name, home;
            int rollNo, mMarks, fMarks, eMarks;
            float cgpa;
            bool isH;
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Matric Marks: ");
            mMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            fMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            eMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter cGPA: ");
            cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Hometown: ");
            home = Console.ReadLine();
            Console.Write("Enter IsHostalite(y/n): ");
            string isHostel = Console.ReadLine();
            if (isHostel == "y")
            {
                isH = true;
            }
            else
            {
                isH = false;
            }
            StudentRecords student = new StudentRecords(name, rollNo, cgpa, mMarks, fMarks, eMarks, home, isH);
            float result = student.calculateMerit();
            Console.WriteLine("Student Merit Is: " + result);
            bool take = student.isEligibleforScholarship(result);
            Console.Write("ScholarShip: ");
            if (take == true)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
            Console.ReadKey();
        }

        
    }
}
