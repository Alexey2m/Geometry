using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

using Geometry.Shapes;

namespace Geometry.ViewModels
{
    /// <summary>
    /// Класс, реализующий менеджер рисования
    /// </summary>
    internal sealed class GraphicsManager : IGraphics
    {
        #region Readonly
        private readonly Canvas _canvas;
        #endregion

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="canvas">Полотно для рисования</param>
        public GraphicsManager(Canvas canvas)
        {
            _canvas = canvas ?? throw new ArgumentNullException(nameof(canvas));
        }

        /// <summary>
        /// Ширина полотна
        /// </summary>
        public int Width => (int)_canvas.ActualWidth;

        /// <summary>
        /// Высота полотна
        /// </summary>
        public int Height => (int)_canvas.ActualHeight;

        /// <summary>
        /// Очистка полотна
        /// </summary>
        public void Clear()
        {
            _canvas.Children.Clear();
        }

        /// <summary>
        /// Нарисовать фигуру
        /// </summary>
        /// <param name="shape"></param>
        public void Draw(Shape shape)
        {
            var figure = Convert(shape);

            _canvas.Children.Add(figure);
        }

        /// <summary>
        /// Преобразование пользовательской фигуры в фигуру для полотна
        /// </summary>
        /// <param name="shape">Фигура пользователя</param>
        /// <returns>Фигура полотна</returns>
        private static UIElement Convert(Shape shape)
        {
            return shape switch
            {
                Line line => MakeLine(line),
                Ellipse ellipse => MakeEllipse(ellipse),
                Circle circle => MakeCircle(circle),
                Rectangle rectangle => MakeRectangle(rectangle),
                Square square => MakeSquare(square),

                _ => new UIElement(),
            };

            static System.Windows.Shapes.Line MakeLine(Line line) => new()
            {
                X1 = 0,
                Y1 = 0,

                X2 = line.To.X - line.From.X,
                Y2 = line.To.Y - line.From.Y,

                Margin = new Thickness(line.From.X, line.From.Y, 0, 0),

                Stroke = new SolidColorBrush(line.Color),
                StrokeThickness = 1,
            };

            static System.Windows.Shapes.Ellipse MakeEllipse(Ellipse ellipse) => new()
            {
                Width = 2 * ellipse.Radius,
                Height = 2 * ellipse.SecondRadius,

                Margin = new Thickness(ellipse.Center.X - ellipse.Radius, ellipse.Center.Y - ellipse.SecondRadius, 0, 0),

                Stroke = new SolidColorBrush(ellipse.Color),
                StrokeThickness = 1,
            };

            static System.Windows.Shapes.Ellipse MakeCircle(Circle circle) => new()
            {
                Width = 2 * circle.Radius,
                Height = 2 * circle.Radius,

                Margin = new Thickness(circle.Center.X - circle.Radius, circle.Center.Y - circle.Radius, 0, 0),

                Stroke = new SolidColorBrush(circle.Color),
                StrokeThickness = 1,
            };

            static System.Windows.Shapes.Rectangle MakeRectangle(Rectangle rectangle) => new()
            {
                Width = rectangle.Size,
                Height = rectangle.SecondSize,

                Margin = new Thickness(rectangle.Start.X, rectangle.Start.Y - rectangle.SecondSize, 0, 0),

                Stroke = new SolidColorBrush(rectangle.Color),
                StrokeThickness = 1,
            };

            static System.Windows.Shapes.Rectangle MakeSquare(Square square) => new()
            {
                Width = square.Size,
                Height = square.Size,

                Margin = new Thickness(square.Start.X, square.Start.Y - square.Size, 0, 0),

                Stroke = new SolidColorBrush(square.Color),
                StrokeThickness = 1,
            };
        }
    }
}