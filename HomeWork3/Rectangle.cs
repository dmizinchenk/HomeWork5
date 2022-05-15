using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Rectangle : Figure, ISimpleNAngle
    {
        (double, double, double, double) length;
        public double Base { get; set; }
        public double Height { get; set; }
        public double Alpha { get; set; }
        public int CountPart { get; set; }
        public (double, double, double, double) Length
        {
            get => length;
            set
            {
                if (value.Item1 > 0 && value.Item2 > 0 && value.Item3 > 0 && value.Item4 > 0)
                    length = value;
                else
                    throw new Exception("Неправильно заданы стороны");
            }
        }

        public Rectangle(double length1, double length2)
        {
            Base = length1;
            Height = length2;
            Length = (length1, length2, length1, length2);
            Alpha = 90;
            CountPart = 4;
        }

        public override double GetArea() => Base * Height;

        public override double GetPerimeter() => 2 * (Base + Height);

    }
}
