using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс квадрат.
    /// </summary>
    [Serializable]
    public class Square:IFigure
    {
        private double _sideA;


        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public Square()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="a">Сторона квадрата.</param>
        public Square(double a)
        {
            SideA = a;
        }

        /// <summary>
        /// Длина основания А трапеции.
        /// </summary>
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _sideA = value;
            }
        }

        /// <summary>
        /// Получение площади трапеции.
        /// </summary>
        /// <returns>Площадь трапеции.</returns>
        public double Area
        {
            get
            {
                if (SideA <= 0)
                {
                    throw new ArgumentException("Квадрат не инициализирован значениями");
                }
                return SideA*SideA;
            }
        }  

        /// <summary>
        /// Получение периметра трапеции.
        /// </summary>
        /// <returns>Периметр трапеции.</returns>
        public double Perimeter
        {
            get
            {
                if (SideA <= 0)
                {
                    throw new ArgumentException("Квадрат не инициализирован значениями");
                }
                return 4 * SideA;
            }
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type
        {
            get
            {
                return "Квадрат";
            }
        }     
    }
}
