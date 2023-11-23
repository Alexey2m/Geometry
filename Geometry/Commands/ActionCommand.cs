using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Commands
{
    /// <summary>
    /// Класс, представляющий команду без параметра
    /// </summary>
    internal sealed class ActionCommand : Command
    {
        #region Readonly
        private readonly Action _action;
        #endregion

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="action">Действие при выполнении команды</param>
        /// <param name="canExecute">Возможность выполнения команды</param>
        public ActionCommand(Action action, bool canExecute = true)
        {
            _action = action;
            IsCanExecute = canExecute;
        }

        /// <summary>
        /// Запуск команды
        /// </summary>
        /// <param name="parameter">Параметр команды не участвует</param>
        public sealed override void Execute(object _)
        {
            _action?.Invoke();
        }
    }
}