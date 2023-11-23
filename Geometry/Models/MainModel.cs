using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Geometry.Shapes;

namespace Geometry.Models
{
    /// <summary>
    /// Класс, описывающий модель
    /// </summary>
    internal sealed class MainModel
    {
        #region Readonly
        private readonly Random _rnd;
        #endregion

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainModel() 
        {
            _rnd = new();
        }

        /// <summary>
        /// Создание заданного количества фигур пользователя с учетом размера полотна
        /// </summary>
        /// <param name="count">Число фигур каждого типа</param>
        /// <param name="widthArea">Ширина полотна</param>
        /// <param name="heightArea">Высота полотна</param>
        /// <returns>Коллекция фигур</returns>
        public IList<Shape> CreateFigures(int count, int widthArea, int heightArea)
        {
            var lines = Enumerable.Repeat(0, count).Select(_ => MakeLine(widthArea, heightArea) as Shape);
            var circles = Enumerable.Repeat(0, count).Select(_ => MakeCircle(widthArea, heightArea) as Shape);
            var ellipses = Enumerable.Repeat(0, count).Select(_ => MakeEllipse(widthArea, heightArea) as Shape);
            var squares = Enumerable.Repeat(0, count).Select(_ => MakeSquare(widthArea, heightArea) as Shape);
            var rectangles = Enumerable.Repeat(0, count).Select(_ => MakeRectangle(widthArea, heightArea) as Shape);

            return lines.Concat(circles).Concat(ellipses).Concat(squares).Concat(rectangles).ToArray();

            Line MakeLine(int widthArea, int heightArea) => new(System.Windows.Media.Colors.Red)
            {
                From = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
                To = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
            };

            Circle MakeCircle(int widthArea, int heightArea) => new(System.Windows.Media.Colors.Blue)
            {
                Center = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
                Radius = (uint)_rnd.Next(Math.Min(widthArea, heightArea) / 4),
            };

            Ellipse MakeEllipse(int widthArea, int heightArea) => new(System.Windows.Media.Colors.Green)
            {
                Center = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
                Radius = (uint)_rnd.Next(widthArea / 4),
                SecondRadius = (uint)_rnd.Next(heightArea / 4),
            };

            Square MakeSquare(int widthArea, int heightArea) => new(System.Windows.Media.Colors.MediumPurple)
            {
                Start = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
                Size = (uint)_rnd.Next(Math.Min(widthArea, heightArea) / 4),
            };

            Rectangle MakeRectangle(int widthArea, int heightArea) => new(System.Windows.Media.Colors.DarkCyan)
            {
                Start = new System.Windows.Point(_rnd.Next(widthArea), _rnd.Next(heightArea)),
                Size = (uint)_rnd.Next(widthArea / 4),
                SecondSize = (uint)_rnd.Next(heightArea / 4),
            };
        }
    }
}