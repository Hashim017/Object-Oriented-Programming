using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class SubjectUI
    {
        public static Subjects takeInputForSubject()
        {
            string code;
            string type;
            int creditHours; int subjectFees;
            Console.Write("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees (PCH): ");
            subjectFees = int.Parse(Console.ReadLine());
            Subjects sub = new Subjects(code, type, creditHours, subjectFees);
            return sub;
        }

        public static void viewSubjects(Students s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach (Subjects sub in s.regDegree.Subject)
                {
                    Console.WriteLine(sub.subjectCode + "\t\t" + sub.subjectType);
                }
            }
        }

        public static void registerSubjects(Students s)
        {
            Console.Write("Enter how many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.Write("Enter the subject Code: ");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (Subjects sub in s.regDegree.Subject)
                {
                    if (code == sub.subjectCode && !(s.regSubject.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Subject Registered Successfully ... !");
                            Console.WriteLine();
                            Flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("A student cannot have more than 9 CH");
                        }
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Valid Code");
                    x--;
                }
            }       
        }
    }
        
}
