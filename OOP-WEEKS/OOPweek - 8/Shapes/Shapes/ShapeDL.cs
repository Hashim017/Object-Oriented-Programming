using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeDL
    {
        private static List<Shape> shapesList = new List<Shape>();
        public static void addIntoList(Shape r)
        {
            shapesList.Add(r);
        }
        public static List<Shape> getList()
        {
            return shapesList;
        }
    }
}
