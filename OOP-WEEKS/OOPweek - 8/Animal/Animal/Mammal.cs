using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Mammal : Animal
    {
        public Mammal(string name):base(name)
        {

        }

        public override string toString()
        {
            string a = "Mammal[" + base.toString() + "]";
            return a;
        }
    }
}
