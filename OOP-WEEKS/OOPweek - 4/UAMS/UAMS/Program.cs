using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Students[] student = new Students[100];
            Subjects[] subject = new Subjects[100];
            DegreePrograms[] degreeProgram = new DegreePrograms[100];
            int subjectCount = 0, studentCount = 0, programCount = 0;
            string option = "";
            while(option != "0")
            {
                option = mainMenu();
                if(option == "1")
                {
                    student[studentCount] = addStudent();
                    studentCount++;
                    Console.WriteLine();
                    Console.WriteLine("Available Degree Programs: ");
                    for (int x = 0; x < programCount; x++)
                    {
                        Console.WriteLine(degreeProgram[x].degreeName);
                    }
                    Console.ReadLine();
                }
                else if(option == "2")
                {
                    degreeProgram[programCount] = addDegreeProgram(subject, ref subjectCount);
                    programCount++;
                }
                if (option == "4")
                {
                    viewStudents(student, studentCount);
                }
                else
                {
                    continue;
                }
            }
        }
        
        static string mainMenu()
        {
            Console.Clear();
            string option; 
            Console.WriteLine("Press One Of The Following Keys: ");
            Console.WriteLine();
            Console.WriteLine("1 - Add Student.");
            Console.WriteLine("2 - Add Degree Program.");
            Console.WriteLine("3 - Generate Merit.");
            Console.WriteLine("4 - View Registered Students.");
            Console.WriteLine("5 - View Students of Specific Program.");
            Console.WriteLine("6 - Register Subjects For A Specific Student.");
            Console.WriteLine("7 - Calculate Fees Of All Registered Students.");
            Console.WriteLine("0 - Exit.");
            Console.WriteLine();
            Console.Write("Enter Option: ");
            option = Console.ReadLine();
            return option;
        }

        static Students addStudent()
        {
            Console.Clear();
            string name;
            int age, fMarks, eMarks;
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            fMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            eMarks = int.Parse(Console.ReadLine());
            Students student = new Students(name, age, fMarks, eMarks);
            return student;
        }

        static DegreePrograms addDegreeProgram(Subjects[] subject, ref int subjectCount)
        {
            Console.Clear();
            string name;
            int duration, seats, numberOfSubjects; ;
            Console.Write("Enter Degree Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            seats = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Subjects To Enter: ");
            numberOfSubjects = int.Parse(Console.ReadLine());
            DegreePrograms degreeProgram = new DegreePrograms(name, duration, seats, numberOfSubjects);
            for (int x = 0; x < numberOfSubjects; x++)
            {
                subject[subjectCount] = addSubjects();
                subjectCount++;
            }
            return degreeProgram;
        }

        static Subjects addSubjects()
        {
            Console.Clear();
            string type;
            int code, creditHours, fees;
            Console.Write("Enter Subject Code: ");
            code = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Type: ");
            type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            fees = int.Parse(Console.ReadLine());
            Subjects s = new Subjects(code, type, creditHours, fees);
            return s;
        }

        static void viewStudents(Students[] student, int studentCount)
        {
            Console.Clear();
            for (int x = 0; x < studentCount; x++)
            {
                int num = 1;
                Console.WriteLine(num + " - " + "Student Name: " + student[x].studentName);
                Console.WriteLine("    Student Age: " + student[x].studentAge);
                Console.WriteLine("    Student FSC Marks: " + student[x].fscMarks);
                Console.WriteLine("    Student ECAT Marks: " + student[x].ecatMarks);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
