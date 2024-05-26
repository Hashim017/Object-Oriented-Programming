using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Students
    {
        public string studentName;
        public int studentAge;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreePrograms> preferences;
        public List<Subjects> regSubject;
        public DegreePrograms regDegree;

        public Students(string name, int age, double fMarks, double eMarks, List<DegreePrograms> programs)
        {
            studentName = name;
            studentAge = age;
            fscMarks = fMarks;
            ecatMarks = eMarks;
            preferences = programs;
            regSubject = new List<Subjects>();
        }

        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
        }
        public bool regStudentSubject(Subjects s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.subjectHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
    
    public int getCreditHours()
    {
        int count = 0;
        foreach (var sub in regSubject)
        {
            count = count + sub.subjectHours;
        }
        return count;
    }

        public float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (var sub in regSubject)
                {
                    fee = fee + sub.subjectFees;
                }
            }
            return fee;
        }
    }
}

