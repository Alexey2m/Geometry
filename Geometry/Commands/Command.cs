using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Geometry.Commands
{
    /// <summary>
    /// Базовый класс для представления команд
    /// </summary>
    internal abstract class Command : ICommand
    {
        #region Variables
        private bool _canExecute = true;
        #endregion

        /// <summary>
        /// Событие изменения возможности выполнения команды
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Возможность выполнения команды
        /// </summary>
        /// <param name="parameter">Параметр не участвует</param>
        /// <returns>Истина, если команда способна выполняться</returns>
        public bool CanExecute(object parameter)
        {
            return IsCanExecute;
        }

        /// <summary>
        /// Запуск команды
        /// </summary>
        /// <param name="parameter">Параметр команды</param>
        public abstract void Execute(object parameter);

        /// <summary>
        /// Возможность выполнения команды
        /// </summary>
        protected bool IsCanExecute
        {
            get => _canExecute;

            set
            {
                if (_canExecute != value)
                {
                    _canExecute = value;

                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}