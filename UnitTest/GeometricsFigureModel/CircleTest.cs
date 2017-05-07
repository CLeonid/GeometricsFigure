using System;

using GeometricsFigure;

using NUnit.Framework;

namespace UnitTest.GeometricsFigureModel

{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(3, ExpectedResult = 28.27, TestName = "Тестирование класса CircleFigure свойства Area при верном значении")]
        [TestCase(-3, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(1, ExpectedResult = 3.14, TestName = "Тестирование класса CircleFigure свойства Area при верном значении")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(2, ExpectedResult = 12.57, TestName = "Тестирование класса CircleFigure свойства Area при верном значении")]
        public double CircleAreaTest(double radius)
        {
            var circle = new CircleFigure(radius);
            return circle.Area;
        }

        [Test]
        [TestCase(3, ExpectedResult = 18.85, TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        [TestCase(-3, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(1, ExpectedResult = 6.28, TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(2, ExpectedResult = 12.57, TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        public double CirclePerimeterTest(double radius)
        {
            var circle = new CircleFigure(radius);
            return circle.Perimeter;
        }
    }
}