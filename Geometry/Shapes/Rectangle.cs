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
    /// Класс, описывающий прямоугольник
    /// </summary>
    internal sealed class Rectangle : Square
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        public Rectangle(Color color, string name = "rectangle") : base(color, name)
        {
        }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public uint SecondSize { get; init; }
    }
}