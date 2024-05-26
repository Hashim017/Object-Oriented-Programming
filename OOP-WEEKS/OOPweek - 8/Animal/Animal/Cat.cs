using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Cat : Mammal
    {

        public Cat(string name):base(name)
        {

        }

        public void greets()
        {
            Console.WriteLine("Meow");
        }

        public override string toString()
        {
            string a = "Cat[" + base.toString() + "]";
            return a;
        }
    }
}
