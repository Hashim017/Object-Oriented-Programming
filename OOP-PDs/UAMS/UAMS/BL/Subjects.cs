using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Subjects
    {
        public string subjectCode;
        public string subjectType;
        public int subjectHours;
        public int subjectFees;

        public Subjects(string code, string type, int hours, int fees)
        {
            subjectCode = code;
            subjectType = type;
            subjectHours = hours;
            subjectFees = fees;
        }
    }
}
