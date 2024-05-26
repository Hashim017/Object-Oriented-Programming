using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_fom
{
    class AdminBL : PersonBL
    {
        public AdminBL(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
    }
}
