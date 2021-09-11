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
    /// Interaction logic for Cap1Ejercicio1.xaml
    /// </summary>
    public partial class Cap1Ejercicio1 : Window
    {
        public static ListView tablaMultiplicacion = new ListView();
        
        public Cap1Ejercicio1()
        {
            InitializeComponent();     
            
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            PanelPrincipal.Children.Remove(tablaMultiplicacion);
            tablaMultiplicacion.Items.Clear();
            int n = int.Parse(NumeroTextbox.Text);
            for (int i = 1; i <= 10; i++)
            {
                 int resultado  = n * i;
                tablaMultiplicacion.Items.Add(resultado);

            }
            PanelPrincipal.Children.Add(tablaMultiplicacion);
            

        }
       
    }
}
