using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class StudentDL
    {
        public static List<Students> studentList = new List<Students>();
        public static void addIntoStudentList(Students s)
        {
            studentList.Add(s);
        }
        public static Students StudentPresent(string name)
        {
            foreach (Students s in studentList)
            {
                if (name == s.studentName && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        public static List<Students> sortStudentsByMerit()
        {
            List<Students> sortedStudentList = new List<Students>();
            foreach (Students s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }

        public static void giveAdmission(List<Students> sortedStudentList)
        {
            foreach (Students s in sortedStudentList)
            {
                foreach (DegreePrograms d in s.preferences)
                {
                    if (d.degreeSeats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.degreeSeats--;
                        break;
                    }
                }
            }
        }
    }
}
