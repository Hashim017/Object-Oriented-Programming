using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class StudentRecords
    {
        public string studentName;
        public int rollNumber;
        public float cGPA;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string hometown;
        public bool isHostalite;
        public bool isTakingScholarship;

        public StudentRecords(string name, int rollNo, float cgpa, int mMarks, int fMarks, int eMarks, string home, bool isH)
        {
            studentName = name;
            rollNumber = rollNo;
            cGPA = cgpa;
            matricMarks = mMarks;
            fscMarks = fMarks;
            ecatMarks = eMarks;
            hometown = home;
            isHostalite = isH;
        }

        public float calculateMerit()
        {
            float result = ((fscMarks * 60f) / 1100f) + ((ecatMarks * 40f) / 400f);
            return result;
        }

        public bool isEligibleforScholarship(float merit)
        {
            if(merit > 80.0f && isHostalite == true)
            {
                isTakingScholarship =  true;
            }
            else
            {
                isTakingScholarship =  false;
            }
            return isTakingScholarship;
        }
    }
}
