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
            AzulRadioButton.IsChecked = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            VisualizarTextoTextBlock.Text = EscribirTextoTextBox.Text;
        }

        private void BoldCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            VisualizarTextoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void BlueRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VisualizarTextoTextBlock.Foreground = Brushes.Blue;
        }

        private void RedRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VisualizarTextoTextBlock.Foreground = Brushes.Red;
        }

        private void GreenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VisualizarTextoTextBlock.Foreground = Brushes.Green;
        }

        private void ItalicCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            VisualizarTextoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void BoldCheckBox_Clicked(object sender, RoutedEventArgs e)
        {
            if ((bool)!NegritaCheckBox.IsChecked)
            {
                VisualizarTextoTextBlock.FontWeight = FontWeights.Normal;
            }
        }

        private void ItalicCheckBox_Clicked(object sender, RoutedEventArgs e)
        {
            if ((bool)!ItalicCheckBox.IsChecked)
            {
                VisualizarTextoTextBlock.FontStyle = FontStyles.Normal;
            }
        }
    }
}
