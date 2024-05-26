using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class SquareUI
    {
        public static Square createShape()
        {
            Square s;
            Console.Write("Enter Side: ");
            int side = int.Parse(Console.ReadLine());
            s = new Square(side);
            return s;
        }
    }
}
