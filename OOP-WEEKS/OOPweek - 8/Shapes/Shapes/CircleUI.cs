using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class CircleUI
    {
        public static Circle createShape()
        {
            Circle c;
            Console.Write("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());
            c = new Circle(radius);
            return c;
        }
    }
}
