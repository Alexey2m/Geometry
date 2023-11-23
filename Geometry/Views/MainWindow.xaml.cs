using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Geometry.ViewModels;

namespace Geometry.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            InitAll();
        }

        /// <summary>
        /// Инициализация модели представления
        /// </summary>
        private void InitAll()
        {
            if (DataContext is MainViewModel vm)
            {
                var graph = new GraphicsManager(canvas);

                vm.Init(graph);
            }
        }
    }
}