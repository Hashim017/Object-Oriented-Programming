using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class StudentUI
    {
        public static void printStudents()
        {
            foreach (Students s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.studentName + " got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.studentName + " did not get Admission");
                }
            }
        }
        public static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Students s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.studentName + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.studentAge);
                    }
                }
            }
        }
        public static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Students s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.studentName + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.studentAge);
                }
            }
        }

        public static Students takeInputForStudent()
        {
            string name;
            int age;
            double fscMarks;
            double ecatMarks;
            List<DegreePrograms> preferences = new List<DegreePrograms>();
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            fscMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            ecatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            DegreeProgramUI.viewDegreePrograms();
            Console.Write("Enter how many preferences to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            for (int x = 0; x < Count; x++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach (DegreePrograms dp in DegreeProgramDL.programList)
                {
                    if (degName == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    x--;
                }
            }
            Students s = new Students(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        public static void calculateFeeForAl1()
        {
            foreach (Students s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.studentName + " has " + s.calculateFee() + " fees");
                }
            }
        }
    }
}
