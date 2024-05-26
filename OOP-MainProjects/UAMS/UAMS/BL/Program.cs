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
            int option = -1;
            do
            {
                MenuUI.header();
                option = MenuUI.Menu();
                if (option == 1)
                {
                    MenuUI.header();
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        Students s = StudentUI.takeInputForStudent();
                        StudentDL.addIntoStudentList(s);
                    }
                    MenuUI.clearScreen();
                }

                else if (option == 2)
                {
                    MenuUI.header();
                    DegreePrograms d = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.addIntoDegreeList(d);
                    MenuUI.clearScreen();
                }
                else if (option == 3)
                {
                    MenuUI.header();
                    List<Students> sortedStudentList = new List<Students>();
                    sortedStudentList = StudentDL.sortStudentsByMerit();
                    StudentDL.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                    MenuUI.clearScreen();
                }
                else if (option == 4)
                {
                    MenuUI.header();
                    StudentUI.viewRegisteredStudents();
                    MenuUI.clearScreen();
                }
                else if (option == 5)
                {
                    MenuUI.header();
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    Console.WriteLine();
                    StudentUI.viewStudentInDegree(degName);
                    MenuUI.clearScreen();
                }

                else if (option == 6)
                {
                    MenuUI.header();
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Students s = StudentDL.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubjects(s);
                    }
                    MenuUI.clearScreen();
                }
                else if (option == 7)
                {
                    MenuUI.header();
                    StudentUI.calculateFeeForAl1();
                    MenuUI.clearScreen();
                }
            } while (option != 8);

        }
    }
}
