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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var fahrenheitString = fahrenheittextBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            var celsius = (fahrenheit - 32) * 5 / 9;
            var celsiusString = celsius.ToString();
            celsiustextBox.Text = celsiusString;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var CelsiusString = celsiustextBox.Text;
            var celsius = double.Parse(CelsiusString);
            var fahrenheit = (celsius* 9/5 ) + 32;
            var fahrenheitString = fahrenheit.ToString();
            fahrenheittextBox.Text = fahrenheitString;
        }
    }
}
