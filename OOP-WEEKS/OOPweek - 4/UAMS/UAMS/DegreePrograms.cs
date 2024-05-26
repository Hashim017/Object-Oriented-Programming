using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class DegreePrograms
    {
        public string degreeName;
        public int degreeDuration;
        public int degreeSeats;
        public int degreeSubjects;

        public DegreePrograms(string name, int duration, int seats, int subjects)
        {
            degreeName = name;
            degreeDuration = duration;
            degreeSeats = seats;
            degreeSubjects = subjects; 
        }
    }
}
