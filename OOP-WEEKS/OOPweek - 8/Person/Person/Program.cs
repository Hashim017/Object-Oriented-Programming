using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Hashim", "Lhr", "CS", 1, 4000.50);
            Student std2 = new Student("Jilani", "Grw", "CS", 1, 6000.70);

            Staff s1 = new Staff("Rehman", "Rwp", "Govt.", 10000.00);
            Staff s2 = new Staff("Ahmad", "Fsd", "Allied", 20000.00);

            Console.WriteLine(std1.toString());
            Console.WriteLine(std2.toString());
            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());
            Console.ReadKey();
        }
    }
}
