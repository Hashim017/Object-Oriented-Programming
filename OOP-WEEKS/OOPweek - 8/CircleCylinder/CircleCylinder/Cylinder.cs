using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCylinder
{
    class Cylinder : Circle
    {
        private double Height = 1.0;

        public Cylinder()
        {

        }

        public Cylinder(double radius):base(radius)
        {

        }

        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            Height = height;
        }

        public void setHeight(double height)
        {
            Height = height;
        }

        public double getHeight()
        {
            return Height;
        }

        public double getVolume()
        {
            double volume = Height * base.getArea();
            return volume;
        }

        public override string toString()
        {
            string a = "Cylinder[Height: " + Height + "]";
            return a;
        }
    }
}
