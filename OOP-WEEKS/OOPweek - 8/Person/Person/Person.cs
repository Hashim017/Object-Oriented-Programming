using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string Name;
        private string Address;

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string getName()
        {
            return Name;
        }

        public void setAddress(string address)
        {
            Address = address;
        }

        public string getAddress()
        {
            return Address;
        }

        public virtual string toString()
        {
            string a = "Person[Name: " + Name + ", Address: " + Address + "]";
            return a;
        }
    }
}
