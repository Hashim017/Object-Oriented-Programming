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
        public float degreeDuration;
        public int degreeSeats;
        public List<Subjects> Subject;

        public DegreePrograms(string name, float duration, int seats)
        {
            degreeName = name;
            degreeDuration = duration;
            degreeSeats = seats;
            Subject = new List<Subjects>();
        }
        public bool isSubjectExists(Subjects sub)
        {
            foreach (var s in Subject)
            {
                if (s.subjectCode == sub.subjectCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddSubject(Subjects s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.subjectHours <= 20)
            {
                Subject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < Subject.Count; x++)
            {
                count = count + Subject[x].subjectHours;

            }
            return count;
        }
    }
}

