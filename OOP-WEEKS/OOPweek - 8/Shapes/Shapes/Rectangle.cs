using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        { 
            return width* height;
        }

        public override string getShapeType()
        { 
            return "Rectangle";
        }
    }
}
