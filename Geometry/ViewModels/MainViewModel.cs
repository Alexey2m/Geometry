using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geometry.Mvvm;
using Geometry.Models;
using Geometry.Commands;

namespace Geometry.ViewModels
{
    /// <summary>
    /// Класс, описывающий модель представления
    /// </summary>
    internal sealed class MainViewModel : ViewModel
    {
        #region Readonly
        private readonly MainModel _model;
        #endregion

        #region Variables
        private IGraphics _graph;
        #endregion

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainViewModel()
        {
            DrawClick = new(Draw);
            ClearClick = new(Clear);
            ExitClick = new(Exit);

            _model = new MainModel();
        }

        /// <summary>
        /// Команда нажатия кнопки рисования
        /// </summary>
        public ActionCommand DrawClick { get; }

        /// <summary>
        /// Команда нажатия кнопки очистки
        /// </summary>
        public ActionCommand ClearClick { get; }

        /// <summary>
        /// Команда нажатия кнопки выхода
        /// </summary>
        public ActionCommand ExitClick { get; }

        /// <summary>
        /// Инициализация модели представления
        /// </summary>
        /// <param name="graph">Менеджер рисования</param>
        public void Init(IGraphics graph)
        {
            Init();

            _graph = graph;
        }

        /// <summary>
        /// Нарисовать фигуры
        /// </summary>
        private void Draw()
        {
            const int count = 3;

            var shapes = _model.CreateFigures(count, _graph.Width, _graph.Height);

            foreach (var item in shapes)
            {
                _graph.Draw(item);
            }
        }

        /// <summary>
        /// Очистить полотно
        /// </summary>
        private void Clear()
        {
            _graph.Clear();
        }

        /// <summary>
        /// Выход из приложения
        /// </summary>
        private void Exit()
        {
            CurrentWindow.Close();
        }
    }
}