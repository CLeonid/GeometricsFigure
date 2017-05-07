using System;
using System.Collections.Generic;
using System.Drawing;

using GeometricsFigure;

namespace GeometricsFigureConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var geometricsFigure = new List<IFigure>();
            var point = new Point(1, 1);

            try
            {
                var rectangleFigure = new GeometricsFigure.Rectangle(3, 2);
                geometricsFigure.Add(rectangleFigure);

                var circleFigure = new Circle(3.5);
                geometricsFigure.Add(circleFigure);

                var triangleFigure = new Triangle(10, 10, 10);
                geometricsFigure.Add(triangleFigure);

                var trapezeFigure = new Square(5);
                geometricsFigure.Add(trapezeFigure);

                foreach (IFigure figure in geometricsFigure)
                {
                    Console.WriteLine("{0}. Площадь = {1}. Периметр = {2}",
                                      figure.Type,
                                      figure.Area,
                                      figure.Perimeter);
                }
            }
            
            catch ( Exception exception )
            {
                Console.WriteLine(exception.Message);
            }



            Console.Read();
        }
    }
}
