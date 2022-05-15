using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Circle : Figure
    {
        double radius;
        public double Radius 
        { 
            get => radius;
            protected set
            {
                if (value > 0)
                    radius = value;
                else
                    radius = 1;
            } 
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;

        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
