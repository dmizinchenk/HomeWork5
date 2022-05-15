using System;
namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Figure ellipse = new Ellipse(5, 7);
                ISimpleNAngle trap = new TrapezoidEqualSide(2, 5, 3);
                ISimpleNAngle rhomb = new Rhomb(4, 30);
                ISimpleNAngle paral = new Parallelogram(8, 3, 15);
                Console.WriteLine($"Периметр эллипса: {ellipse.GetPerimeter()}");
                Console.WriteLine($"Площадь эллипса: {ellipse.GetArea()}");

                CompositeFigure cf = new CompositeFigure();
                cf.Add(paral);
                cf.Add(trap);
                cf.Add(rhomb);
                cf.Add(paral);
                cf.Add(new Square(5));
                cf.Remove(new Square(5));
                cf.Remove(paral);
                Console.WriteLine($"Общая площадь составной фигуры: {cf.GetArea()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
