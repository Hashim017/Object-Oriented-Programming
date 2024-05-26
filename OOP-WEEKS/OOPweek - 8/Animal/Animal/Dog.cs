using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Mammal
    {

        public Dog(string name):base(name)
        {

        }

        public void greets()
        {
            Console.WriteLine("Woof");
        }

        public void greets(Dog another)
        {
            Console.WriteLine("Wooooof");
        }

        public override string toString()
        {
            string a = "Dog[" + base.toString() + "]";
            return a;
        }
    }
}
