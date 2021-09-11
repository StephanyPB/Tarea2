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
    /// Interaction logic for Cap4Ejercicio5.xaml
    /// </summary>
    public partial class Cap4Ejercicio5 : Window
    {
        public Cap4Ejercicio5()
        {
            InitializeComponent();
        }

        private void Calcularpromediodeedades_Click(object sender, RoutedEventArgs e)
        {

            int edad1 = int.Parse(Edad1TextBox.Text);
            int edad2 = int.Parse(Edad2TextBox.Text);
            int edad3 = int.Parse(Edad3TextBox.Text);
            int edad4 = int.Parse(Edad4TextBox.Text);
            int edad5 = int.Parse(Edad5TextBox.Text);
            int edad6 = int.Parse(Edad6TextBox.Text);
            int edad7 = int.Parse(Edad7TextBox.Text);
            int edad8 = int.Parse(Edad8TextBox.Text);

            int promedio = edad1 + edad2 + edad3 + edad4 + edad5 + edad6 + edad7 + edad8;
            promedio = promedio / 8;
            promediodeedadesTextBox.Text = promedio.ToString();
  
        }
    }
}
