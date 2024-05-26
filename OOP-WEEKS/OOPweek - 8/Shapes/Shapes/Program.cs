using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = RectangleUI.createShape();
            ShapeDL.addIntoList(r);
            Circle c = CircleUI.createShape();
            ShapeDL.addIntoList(c);
            Square s = SquareUI.createShape();
            ShapeDL.addIntoList(s);
            Rectangle r1 = RectangleUI.createShape();
            ShapeDL.addIntoList(r1);
            Circle c1 = CircleUI.createShape();
            ShapeDL.addIntoList(c1);
            ShapeUI.showAreas(ShapeDL.getList());
            Console.ReadKey();
        }
    }
}
