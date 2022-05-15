using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Parallelogram : Rectangle
    {
        public Parallelogram(double length1, double length2, double alpha = 45) : base(length1, length2)
        {
            if (alpha <= 0 || alpha >= 180 )
                throw new Exception("Неправильно задан угол");
            Alpha = alpha;
            Height = length2 * Math.Sin(alpha);
        }
    }
}
