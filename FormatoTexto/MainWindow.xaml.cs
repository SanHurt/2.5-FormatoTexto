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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorAzulRadioButton.IsChecked = true;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoFormateadoTextBlock.Text = textoTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
