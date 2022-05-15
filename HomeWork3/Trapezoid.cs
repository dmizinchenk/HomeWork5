using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class TrapezoidEqualSide : Figure, ISimpleNAngle
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

        public TrapezoidEqualSide(double a, double b, double c)
        {
            if (b + 2 * c <= a)
                throw new Exception("Неправильно заданы стороны");
            double median = (a + b) / 2;
            Length = (a, c, b, c);
            Alpha = Math.Acos((median - b) / c);
            Base = a;
            Height = c * Math.Sin(Alpha);
            CountPart = 4;
        }
        public override double GetArea()
        {
            return Height * (Length.Item1 + Length.Item3) / 2;
        }

        public override double GetPerimeter()
        {
            return Length.Item1 + Length.Item2 + Length.Item3 + Length.Item4;
        }
    }
}
