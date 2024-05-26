using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class DegreeProgramDL
    {
        public static List<DegreePrograms> programList = new List<DegreePrograms>();
        public static void addIntoDegreeList(DegreePrograms d)
        {
            programList.Add(d);

        }

        public static DegreePrograms isDegreeExists(string degreeName)
        {
            foreach (DegreePrograms d in programList)
            {
                if (d.degreeName == degreeName)
                {
                    return d;
                }
            }
            return null;
        }
    }
}
