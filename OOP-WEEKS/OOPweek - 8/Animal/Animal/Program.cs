using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("cat1");
            Cat c2 = new Cat("cat2");
            Dog d1 = new Dog("dog1");
            Dog d2 = new Dog("dog2");
            Mammal m = new Mammal("Whale");
            Animal a = new Animal("bhens");

            Console.WriteLine(a.toString());
            a = m;
            Console.WriteLine(a.toString());
            a = c1;
            Console.WriteLine(a.toString());
            c1.greets();
            a = c2;
            Console.WriteLine(a.toString());
            c2.greets();
            a = d1;
            Console.WriteLine(a.toString());
            d1.greets();
            a = d2;
            Console.WriteLine(a.toString());
            d2.greets(d2);
            Console.ReadKey();
        }
    }
}
