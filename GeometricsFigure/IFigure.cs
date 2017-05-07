namespace GeometricsFigure
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получение площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double Area { get; }

        /// <summary>
        /// Получение периметра фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        double Perimeter { get; }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        string Type { get; }
    }
}
