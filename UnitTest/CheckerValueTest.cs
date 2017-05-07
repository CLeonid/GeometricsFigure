using System;
using GeometricsFigure;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class CheckerValuesTest
    {
        [Test]
        [TestCase(3, ExpectedResult = 3, TestName = "Тестирование Value при значении = 3")]
        [TestCase(-3, ExpectedException = (typeof(ArgumentException)), TestName = "Тестирование Value при значении = -3")]
        [TestCase(1, ExpectedResult = 1, TestName = "Тестирование Value при значении = 1")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)), TestName = "Тестирование Value при значении = -1")]
        [TestCase(2, ExpectedResult = 2, TestName = "Тестирование Value при значении = 2")]

        public double CheckerValueTest(double value)
        {
            return CheckerValues.CheckValue(value);
        }
    }
}