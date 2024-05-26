using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Staff : Person
    {
        private string School;
        private double Pay;

        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public void setSchool(string school)
        {
            School = school;
        }

        public string getSchool()
        {
            return School;
        }

        public void setPay(double pay)
        {
            Pay = pay;
        }

        public double getPay()
        {
            return Pay;
        }

        public new string toString()
        {
            string a = base.toString() + " Staff[School: " + School + ", Pay: " + Pay + "]";
            return a;
        }
    }
}
