using System;

using NUnit.Framework;

using GeometricsFigure;

namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(1, 2, 2, TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(1, -2, 3, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(4, 4, 6, TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(10, 10, 100, ExpectedException = typeof(ArgumentException),
                TestName =
                        "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, несуществующий треугольник")
        ]
        [TestCase(8, 8, 5, TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        public void SetSidesTest(double a, double b, double c)
        {
            var triangle = new TriangleFigure(a, b, c);
            if ( triangle.SideA == a && triangle.SideB == b && triangle.SideC == c )
            {
                return;
            }
            throw new Exception();
        }

        [Test]
        [TestCase(1, 2, 2, ExpectedResult = 0.97,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(1, -2, 3, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(4, 4, 6, ExpectedResult = 7.94,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(10, 10, 100, ExpectedException = typeof(ArgumentException),
                TestName =
                        "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, несуществующий треугольник")
        ]
        [TestCase(8, 8, 5, ExpectedResult = 19,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        public double TriangleAreaTest(double a, double b, double c)
        {
            var triangle = new TriangleFigure(a, b, c);
            return triangle.Area;
        }

        [Test]
        [TestCase(1, 2, 2, ExpectedResult = 5,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(1, -2, 3, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(4, 4, 6, ExpectedResult = 14,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        [TestCase(10, 10, 100, ExpectedException = typeof(ArgumentException),
                TestName =
                        "Тестирование класса TriangleFigure при присвоении сторон при ошибочных значениях, несуществующий треугольник")
        ]
        [TestCase(8, 8, 5, ExpectedResult = 21,
            TestName = "Тестирование класса TriangleFigure при присвоении сторон с верными значениями")]
        public double TrianglePerimeterTest(double a, double b, double c)
        {
            var triangle = new TriangleFigure(a, b, c);
            return triangle.Perimeter;
        }
    }
}