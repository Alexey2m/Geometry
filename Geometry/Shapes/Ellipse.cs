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
    /// Класс, описывающий эллипс
    /// </summary>
    internal sealed class Ellipse : Circle
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        public Ellipse(Color color, string name = "ellipse") : base(color, name)
        {
        }

        /// <summary>
        /// Второй радиус
        /// </summary>
        public uint SecondRadius { get; init; }
    }
}