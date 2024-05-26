using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeUI
    {
        public static void showAreas(List<Shape> shapesList)
        {
            for (int idx = 0; idx < shapesList.Count; idx++)
            {
                Shape s = shapesList[idx];
                Console.WriteLine("The Shape Is " + s.getShapeType() + " And Its Area Is " + s.getArea());
            }
        }
    }
}
