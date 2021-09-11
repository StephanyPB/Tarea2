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
using System.Windows.Shapes;

namespace Tarea2.UI
{
    /// <summary>
    /// Interaction logic for Cap4Ejercicio2.xaml
    /// </summary>
    public partial class Cap4Ejercicio2 : Window
    {
        public Cap4Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(NumeroElevarTexBox.Text);
            int elevado = int.Parse(ElevacionTexBox.Text);
            double potencia = Math.Pow(n, elevado);
            ResultadoTexBox.Text = potencia.ToString();
            
        }
    }
}
