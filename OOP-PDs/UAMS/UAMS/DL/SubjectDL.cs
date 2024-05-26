using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UAMS
{
    class SubjectDL
    {
        public static List<Subjects> subjectList = new List<Subjects>();
        public static void addSubjectIntoList(Subjects s)
        {
            subjectList.Add(s);

        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    Subjects s = new Subjects(code, type, creditHours, subjectFees);
                    addSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeintoFile(string path, Subjects s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.subjectCode + "," + s.subjectType + "," + s.subjectHours + "," + s.subjectFees);
            f.Flush();
            f.Close();
        }
        public static Subjects isSubjectExists(string type)
        {
            foreach (var s in subjectList)
            {
                if (s.subjectType == type)
                {
                    return s;
                }
            }
            return null;
        }
    }
}

