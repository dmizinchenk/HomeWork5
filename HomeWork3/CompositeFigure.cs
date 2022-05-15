using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class CompositeFigure
    {
        List<ISimpleNAngle> figures;

        public CompositeFigure()
        {
            figures = new List<ISimpleNAngle>();
        }
        public void Add(ISimpleNAngle figure)
        {
            figures.Add(figure);
            Console.WriteLine($"Добавление {figure.GetType()} прошло успешно");
        }
        public void Remove(ISimpleNAngle figure)
        {
            if(figures.Remove(figure))
            {
                Console.WriteLine($"Удаление {figure.GetType()} прошло успешно");
                return;
            }
            Console.WriteLine($"Удаление {figure.GetType()} не было произведено");
        }
        public double GetArea()
        {
            double totalArea = 0;
            foreach(var fig in figures)
                totalArea += fig.GetArea();
            return totalArea;
        }
    }
}
