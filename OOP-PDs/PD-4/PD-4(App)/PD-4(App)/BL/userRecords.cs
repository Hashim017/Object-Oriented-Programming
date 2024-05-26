using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_4_App_.BL
{
    class userRecords
    {
        public string username;
        public string password;

        public userRecords(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public void removeUser()
        {
            username = "!";
        }
    }
}
