using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace Geometry
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Запуск приложения
        /// </summary>
        /// <param name="e">Аргументы события запуска</param>
        protected sealed override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ExceptionHandling();
        }

        /// <summary>
        /// Подписка на события, возникающие при необработанных исключениях
        /// </summary>
        private static void ExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            {
                string source = nameof(AppDomain.CurrentDomain.UnhandledException);

                RiseUnhandledException(e.ExceptionObject as Exception, source, e.IsTerminating);
            };

            static void RiseUnhandledException(Exception ex, string source, bool isTerminating = false)
            {
                string output = @$"Перехвачено исключение.
                    Источник: {source}
                    Сообщение: {ex.Message}
                    StackTrace: {ex.StackTrace}";

                Trace.WriteLine(output);

                if (isTerminating)
                {
                    MessageBox.Show("Приложение будет завершено");
                }
            }
        }
    }
}