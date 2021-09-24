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

namespace CalculadoraBasica._2._2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operador;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void RealizarOperaciones()
        {
            {
                try
                {

                    int operando1 = int.Parse(Operando1TextBox.Text);
                    int operando2 = int.Parse(Operando2TextBox.Text);
                    int resultado;

                    operador = OperadorTextBox.Text;
                    switch (operador)
                    {
                        case "+":
                            CalularButton.IsEnabled = true;
                            resultado = operando1 + operando2;
                            ResultadoTextBox.Text = resultado.ToString();
                            break;
                        case "-":
                            CalularButton.IsEnabled = true;
                            resultado = operando1 - operando2;
                            ResultadoTextBox.Text = resultado.ToString();
                            break;
                        case "*":
                            CalularButton.IsEnabled = true;
                            resultado = operando1 * operando2;
                            ResultadoTextBox.Text = resultado.ToString();
                            break;
                        case "/":
                            CalularButton.IsEnabled = true;
                            resultado = operando1 / operando2;
                            ResultadoTextBox.Text = resultado.ToString();
                            break;
                        default:
                            CalularButton.IsEnabled = false;
                            break;
                    }
                }
                catch {
                    MessageBox.Show("Debe introducir un valor");
                }
            }
        }

        private void CalularButton_Click(object sender, RoutedEventArgs e)
        {
            RealizarOperaciones();
        }

            private void LimparButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            operador = OperadorTextBox.Text;
            switch (operador)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    CalularButton.IsEnabled = true;
                    break;
                default:
                    CalularButton.IsEnabled = false;
                    break;
            }
        }
    }
}
