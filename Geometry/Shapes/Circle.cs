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
    /// Класс, описывающий круг
    /// </summary>
    internal class Circle : Shape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        public Circle(Color color, string name = "circle") : base(color, name)
        {
        }

        /// <summary>
        /// Точка центра
        /// </summary>
        public Point Center { get; init; }

        /// <summary>
        /// Радиус
        /// </summary>
        public uint Radius { get; init; }
    }
}