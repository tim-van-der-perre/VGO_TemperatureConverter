using System;
using System.Collections.Generic;
using System.Globalization;
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
    }
        /*
        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var fahrenheitString = fahrenheitTextbox.Text;
            var fahrenheit = double.Parse(fahrenheitString);

             var celsius = (fahrenheit - 32) * 5 / 9;
             var celsiusString = celsius.ToString();
             celsiusTextbox.Text = celsiusString;

             var kelvin = celsius + 273.15;
             var kelvinString = kelvin.ToString();
             kelvinTextbox.Text = kelvinString;
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
             var CelsiusString = celsiusTextbox.Text;
             var celsius = double.Parse(CelsiusString);

             var fahrenheit = (celsius* 9/5 ) + 32;
             var fahrenheitString = fahrenheit.ToString();
             fahrenheitTextbox.Text = fahrenheitString;

             var kelvin = celsius + 273.15;
            var kelvinString = kelvin.ToString();
             kelvinTextbox.Text = kelvinString;
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var kelvinString = kelvinTextbox.Text;
            var kelvin = double.Parse(kelvinString);

            var celsius = kelvin - 273.15;
            var celsiusString = celsius.ToString();
            celsiusTextbox.Text = celsiusString;

            var fahrenheit = (celsius * 9 / 5) + 32;
            var fahrenheitString = fahrenheit.ToString();
            fahrenheitTextbox.Text = fahrenheitString;
        }
        */
       
    public class CelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var celsius = kelvin - 273.15;

            return celsius;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var celsius = double.Parse((String)value);
            var kelvin = celsius + 273.15;

            return kelvin;
        }
    }
    public class FahrenheitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var fahrenheit = ((kelvin - 273.15)*9/5) + 32;

            return fahrenheit;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fahrenheit = double.Parse((String)value);
            var kelvin = ((fahrenheit -32)*5/9)+273.15;

            return kelvin;
        }
    }
}
