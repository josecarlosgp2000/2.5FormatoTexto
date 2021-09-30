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
        }

        private void TextoUsuarioTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {          
                ResultadoTextBlock.Text = TextoUsuarioTextBox.Text;
            
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            ResultadoTextBlock.Foreground = Brushes.Green;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaTextBox_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaTextBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
