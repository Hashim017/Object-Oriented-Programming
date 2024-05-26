using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public Student(string name, string address, string program, int year, double fee):base(name,address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public void setProgram(string program)
        {
            Program = program;
        }

        public string getProgram()
        {
            return Program;
        }

        public int getYear()
        {
            return Year;
        }

        public void setYear(int year)
        {
            Year = year;
        }
        public double getFee()
        {
            return Fee;
        }

        public void setFee(double fee)
        {
            Fee = fee;
        }

        public new string toString()
        {
            string a = base.toString() + " Student[Program: " + Program + ", Year: " + Year + ", Fee: " + Fee + "]";
            return a;
        }
    }
}
