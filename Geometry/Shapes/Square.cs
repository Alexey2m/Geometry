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
    /// Класс, описывающий квадрат
    /// </summary>
    internal class Square : Shape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        public Square(Color color, string name = "square") : base(color, name)
        {
        }

        /// <summary>
        /// Точка начала построения
        /// </summary>
        public Point Start { get; init; }

        /// <summary>
        /// Сторона
        /// </summary>
        public uint Size { get; init; }
    }
}