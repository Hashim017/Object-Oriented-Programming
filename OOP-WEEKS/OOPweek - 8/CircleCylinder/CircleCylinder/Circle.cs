using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCylinder
{
    class Circle
    {
        private double Radius = 1.0;
        private string Color = "red";

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public void setRadius(double radius)
        {
            Radius = radius;
        }

        public double getRadius()
        {
            return Radius;
        }

        public void setColor(string color)
        {
            Color = color;
        }

        public string getColor()
        {
            return Color;
        }

        public double getArea()
        {
            double area = Radius * Radius;
            return area;
        }

        public virtual string toString()
        {
            string a = "Circle[Radius: " + Radius + ", Color: " + Color + "]";
            return a;
        }
    }
}
