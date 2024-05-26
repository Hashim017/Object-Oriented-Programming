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
        public int fscMarks;
        public int ecatMarks;

        public Students(string name, int age, int fMarks, int eMarks)
        {
            studentName = name;
            studentAge = age; 
            fscMarks = fMarks;
            ecatMarks = eMarks;
        }

    }
}
