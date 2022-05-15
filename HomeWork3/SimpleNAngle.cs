using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    interface ISimpleNAngle
    {
        double Height { get; protected set; }
        double Base { get; protected set; }
        double Alpha { get; protected set; }
        int CountPart { get; protected set; }
        (double, double, double, double) Length { get; protected set; }
        double GetArea();
        double GetPerimeter();

    }
}
