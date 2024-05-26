using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }

        public override double getArea()
        {
            double area;
            area = Math.Pow(side, 2);
            return area;
        }

        public override string getShapeType()
        { 
            return "Square";
        }
    }
}
