using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Geometry.Shapes
{
    /// <summary>
    /// Базовый класс фигуры пользователя
    /// </summary>
    internal abstract class Shape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="name">Имя фигуры</param>
        protected Shape(Color color, string name = "shape")
        {
            Color = color;
            Name = name;
        }

        /// <summary>
        /// Имя фигуры
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public Color Color { get; }

        /// <summary>
        /// Строковое представление
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Shape {Name} of color {Color}";
        }

        /// <summary>
        /// Хэш-функция
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}