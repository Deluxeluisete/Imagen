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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void RellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Fill;
        }

        private void UniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.UniformToFill;
        }

        private void SinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.None;
        }

        private void BajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.3;
        }

        private void MediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.6;
        }

        private void AltaRadioutton_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 1;
        }
    }
}
