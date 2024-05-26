using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class DegreeProgramUI
    {
        public static DegreePrograms takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            DegreePrograms degProg = new DegreePrograms(degreeName, degreeDuration, seats);
            Console.Write("Enter How many Subjects to Enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Subjects s = SubjectUI.takeInputForSubject();
                if (degProg.AddSubject(s))
                {
                    if (!(SubjectDL.subjectList.Contains(s)))
                    {
                        SubjectDL.addSubjectIntoList(s);
                    }

                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 credit hour limit exceeded");
                    x--;
                }
            }
            return degProg;
        }
        public static void viewDegreePrograms()
        {
            foreach (DegreePrograms dp in DegreeProgramDL.programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
    }
    
}
