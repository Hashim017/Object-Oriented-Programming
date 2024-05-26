using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class FireFighter : Employee
    {
        public FireFighter(string name, int age):base(name, age)
        {

        }

        public bool isFireBhuja()
        {
            return true;
        }

        public bool isDriver()
        {
            return true;
        }

    }
}
