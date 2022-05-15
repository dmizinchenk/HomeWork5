using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Ellipse : Circle
    {
        double bigRadius;
        public double SmallRadius { get => Radius; protected set => Radius = value; }
        public double BigRadius
        {
            get => bigRadius;
            protected set
            {
                if (value > SmallRadius)
                    bigRadius = value;
                else
                    bigRadius = Radius + 1;
            }
        }
        public Ellipse(double smallRadius, double bigRadius) : base(smallRadius)
        {
            BigRadius = bigRadius;
        }
        public override double GetArea() => Math.PI * BigRadius * SmallRadius;

        public override double GetPerimeter() => 2 * Math.PI * Math.Sqrt((Math.Pow(BigRadius,2)+ Math.Pow(SmallRadius, 2)) /2);
    }
}
