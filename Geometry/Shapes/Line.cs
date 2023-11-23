using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Geometry.Shapes
{
    /// <summary>
    /// Класс, описывающий линию
    /// </summary>
    internal sealed class Line : Shape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        public Line(Color color, string name = "line") : base(color, name)
        {
        }

        /// <summary>
        /// Начальная точка
        /// </summary>
        public Point From { get; init; }

        /// <summary>
        /// Конечная точка
        /// </summary>
        public Point To { get; init; }
    }
}