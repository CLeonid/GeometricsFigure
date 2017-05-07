using System;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс окружность.
    /// </summary>
    [Serializable]
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

        /// <summary>
        /// Пустой конструктор окружности.
        /// </summary>
        public Circle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Площадь окружности.
        /// </summary>
        public double Area
        {
            get
            {
                if (_radius <= 0)
                {
                    throw new ArgumentException("Радиус не должен быть равен нулю");
                }
                return Math.PI * Radius * Radius;
            }
        }

        /// <summary>
        /// Периметр окружности.
        /// </summary>
        /// <returns>Периметр окружности.</returns>
        public double Perimeter
        {
            get
            {
                if (_radius <= 0)
                {
                    throw new ArgumentException("Окружность не инициализирована значениями");
                }
                return 2 * Math.PI * Radius;
            }
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type
        {
            get { return "Окружность"; }
        }
    }
}
