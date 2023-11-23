using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Geometry.Mvvm
{
    /// <summary>
    /// Базовый класс для представления типа данных, поддерживающих уведомление об изменении свойств
    /// </summary>
    internal abstract class Notifier : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие изменения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызов события изменения свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var args = new PropertyChangedEventArgs(propertyName);

            OnPropertyChanged(args);
        }

        /// <summary>
        /// Вызов события изменения свойства
        /// </summary>
        /// <param name="e">Данные события</param>
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}