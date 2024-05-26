using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class RectangleUI
    {
        public static Rectangle createShape()
        {
            Rectangle r;
            Console.Write("Enter Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            int height = int.Parse(Console.ReadLine());
            r = new Rectangle(width, height);
            return r;
        }
    }
}
