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

namespace T2_ej2
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

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                double primerNumero = double.Parse(operador1TextBox.Text);
                double segundoNumero = double.Parse(operador2TextBox.Text);

                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = (primerNumero + segundoNumero).ToString();
                    break;
                    case "-":
                        resultadoTextBox.Text = (primerNumero - segundoNumero).ToString();
                    break;
                    case "*":
                        resultadoTextBox.Text = (primerNumero * segundoNumero).ToString();
                    break;
                    case "/":
                        resultadoTextBox.Text = Math.Round(primerNumero / segundoNumero, 1).ToString();
                    break;
                }
            }
            catch {
                MessageBox.Show("Se ha producido un error. Revise los operandos", "" ,MessageBoxButton.OK);
            }
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBox.Text = "";
            operadorTextBox.Text = "";
            operador1TextBox.Text = "";
            operador2TextBox.Text = "";
            calcularButton.IsEnabled = false;
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text == "/" || operadorTextBox.Text == "*" || operadorTextBox.Text == "-" || operadorTextBox.Text == "+")
                calcularButton.IsEnabled = true;
        }
    }
}
