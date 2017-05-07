using System;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс треугольник.
    /// </summary>
    [Serializable]
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        /// <summary>
        /// Пустой конструктор треугольника.
        /// </summary>
        public Triangle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона В</param>
        /// <param name="c">Сторона С</param>
        public Triangle(double a, double b, double c)
        {
            SetSides(a, b, c);
        }

        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA
        {
            get { return _sideA; }
        }

        /// <summary>
        /// Сторона В
        /// </summary>
        public double SideB
        {
            get { return _sideB; }
        }

        /// <summary>
        /// Сторона С
        /// </summary>
        public double SideC
        {
            get { return _sideC; }
        }

        /// <summary>
        /// Функция проверки сторон треугольника.
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона В</param>
        /// <param name="c">Сторона С</param>
        public void SetSides(double a, double b, double c)
        {
            if ((a + c) <= b || (b + c) <= a || (a + b) <= c)
            {
                throw new ArgumentException("Неверно введены стороны треугольника");
            }
            else if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными или равными нулю");
            }
            else
            {
                _sideA = a;
                _sideB = b;
                _sideC = c;
            }
        }

        /// <summary>
        /// Получение полупериметра треугольника
        /// </summary>
        /// <returns>Полупериметр треугольника</returns>
        public double GetSemiPerimetr()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Треугольник не инициализирован значениями");
            }
            return (SideA + SideB + SideC) / 2;
        }


        /// <summary>
        /// Получение площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double Area
        {
            get
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    throw new ArgumentException("Треугольник не инициализирован значениями");
                }
                var semi = GetSemiPerimetr();
                var area = semi * ((semi - SideA)) * (semi - SideB) * (semi - SideC);
                return Math.Sqrt(area);
            }
        }

        /// <summary>
        /// Получение периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double Perimeter
        {
            get
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    throw new ArgumentException("Треугольник не инициализирован значениями");
                }
                return (SideA + SideB + SideC);
            }
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type
        {
            get { return "Треугольник"; }
        }
    }
}
