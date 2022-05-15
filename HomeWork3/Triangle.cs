using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Triangle : Figure, ISimpleNAngle
    {
        (double, double, double, double) length;
        public double Height { get; set; }
        public double Base { get; set; }
        public double Alpha { get; set; }
        public int CountPart { get; set; }
        public (double, double, double, double) Length
        {
            get => length;
            set
            {
                if (value.Item1 > 0 && value.Item2 > 0 && value.Item3 > 0)
                    length = value;
                else
                    throw new Exception("Неправильно заданы стороны");
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c)
                throw new Exception("Неправильно заданы стороны");
            Length = (a, b, c, 0);
            Base = b;
            Alpha = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            Height = c*Math.Sin(Alpha);
            CountPart = 3;
        }
        public override double GetArea() => Base * Height / 2;

        public override double GetPerimeter() => Length.Item1+Length.Item2+Length.Item3;
    }
}
