using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace Geometry.Mvvm
{
    /// <summary>
    /// Базовый класс модели представления
    /// </summary>
    internal abstract class ViewModel : Notifier
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected ViewModel()
        {
        }

        /// <summary>
        /// Текущее окно
        /// </summary>
        protected Window CurrentWindow { get; private set; }

        /// <summary>
        /// Инициализация
        /// </summary>
        public virtual void Init()
        {
            CurrentWindow = GetCurrentWindowOrMain();
        }

        /// <summary>
        /// Возвращает текущее окно или главное, если текущее не найдено
        /// </summary>
        private Window GetCurrentWindowOrMain()
        {
            var all = Application.Current.Windows.OfType<Window>();
            var windows = all.Where(p => p.DataContext is not null);
            var wnd = windows.FirstOrDefault(p => p.DataContext == this);

            return wnd ?? windows.Last();
        }
    }
}