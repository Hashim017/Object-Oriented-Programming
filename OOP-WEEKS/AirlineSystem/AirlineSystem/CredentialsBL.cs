using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class CredentialsBL
    {
        public string Username;
        public string Password;

        public CredentialsBL(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
