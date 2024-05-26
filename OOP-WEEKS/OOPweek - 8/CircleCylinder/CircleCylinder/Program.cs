using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleCylinder;

namespace CircleCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(10, 10);
            Cylinder c3 = new Cylinder(7, 7, "yellow");
            c3.setHeight(2);
            Console.WriteLine("Volume: " + c3.getVolume());
            Console.ReadKey();
        }
    }
}
