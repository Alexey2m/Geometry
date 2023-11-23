using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geometry.Shapes;

namespace Geometry.ViewModels
{
    /// <summary>
    /// Интерфейс, представляющий менеджер рисования
    /// </summary>
    internal interface IGraphics
    {
        /// <summary>
        /// Ширина полотна
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Высота полотна
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Нарисовать фигуру
        /// </summary>
        /// <param name="shape"></param>
        void Draw(Shape shape);

        /// <summary>
        /// Очистить полотно
        /// </summary>
        void Clear();
    }
}