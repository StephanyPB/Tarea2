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
    /// Interaction logic for Cap5Ejercicio4.xaml
    /// </summary>
    public partial class Cap5Ejercicio4 : Window
    {
        double grados, radianes;
        public Cap5Ejercicio4()
        {
            InitializeComponent();
        }

        private void ConvertirButton_Click(object sender, RoutedEventArgs e)
        {
                      
            grados = double.Parse(CantidadGradosTextBox.Text);
            radianes = grados * 3.1416 / 180;
            radianes = Math.Round(radianes, 2);
            resultadoTextBox.Text = radianes.ToString();
            
        }
        //public static double ConvertirGrados()
        //{
            
            //double radianes = grados * 3.1416 /180;
           // return radianes;
        //}
    }
}
