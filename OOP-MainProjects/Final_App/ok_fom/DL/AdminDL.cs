using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ok_fom
{
    class AdminDL
    {
        public static List<AdminBL> AllAdmins = new List<AdminBL>();

        public static void addAdmin(AdminBL admin)
        {
            AllAdmins.Add(admin);
        }

        // check if admin credentials are valid

        public static bool checkAdmin(AdminBL admin)
        {
            bool check = false;
            for (int x = 0; x < AllAdmins.Count; x++)
            {
                if (AllAdmins[x].Username == admin.Username && AllAdmins[x].Password == admin.Password)
                {
                    check = true;
                }
            }
            return check;
        }

        // store admins credentials into file

        public static void storeAdmins()
        {
            StreamWriter data = new StreamWriter("Admins.txt");
            for (int x = 0; x < AllAdmins.Count; x++)
            {
                data.WriteLine(AllAdmins[x].Username + "," + AllAdmins[x].Password);
            }
            data.Close();
        }

        // loads admins credentials from file

        public static void loadAdmins()
        {
            string record = "";
            StreamReader data = new StreamReader("Admins.txt");
            while ((record = data.ReadLine()) != null)
            {
                string username = (findData(record, 1));
                string password = (findData(record, 2));
                AdminBL user = new AdminBL(username, password);
                AdminDL.addAdmin(user);
            }
            data.Close();
        }

        static string findData(string record, int field)
        {
            int comma = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

    }
}

