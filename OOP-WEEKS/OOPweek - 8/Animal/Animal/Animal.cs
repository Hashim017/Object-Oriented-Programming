using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        protected string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public virtual string toString()
        {
            string a = "Animal[Name: " + Name + "]";
            return a;
        }
    }
}
