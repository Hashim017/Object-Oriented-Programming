using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class CredentialsDL
    {
        public static List<CredentialsBL> Users = new List<CredentialsBL>();
        public static List<CredentialsBL> Admins = new List<CredentialsBL>();

        public static void addUser(CredentialsBL user)
        {
            Users.Add(user);
        }

        public static bool checkUser(CredentialsBL user)
        {
            bool check = false;
            for (int x = 0; x < Users.Count; x++)
            {
                if(Users[x].Username == user.Username && Users[x].Password == user.Password)
                {
                    check = true;
                }
            }
            return check;
        }

        public static void addAdmin(CredentialsBL admin)
        {
            Admins.Add(admin);
        }

        public static bool checkAdmin(CredentialsBL admin)
        {
            bool check = false;
            for (int x = 0; x < Admins.Count; x++)
            {
                if (Admins[x].Username == admin.Username && Admins[x].Password == admin.Password)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
