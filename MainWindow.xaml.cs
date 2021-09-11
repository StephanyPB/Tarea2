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
using Tarea2.UI;
namespace Tarea2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListView tablaMultiplicacion = new ListView();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cap4Ejercicio1Item_Click(object sender, RoutedEventArgs e)
        {
            Cap1Ejercicio1 cap4Ejercicio1 = new Cap1Ejercicio1();
            cap4Ejercicio1.Show();
        }

        private void Cap4Ejercicio2Item_Click(object sender, RoutedEventArgs e)
        {
            Cap4Ejercicio2 cap4Ejercicio2 = new Cap4Ejercicio2();
            cap4Ejercicio2.Show();
        }

        private void Cap4Ejercicio5Item_Click(object sender, RoutedEventArgs e)
        {
            Cap4Ejercicio5 cap4Ejercicio5 = new Cap4Ejercicio5();
            cap4Ejercicio5.Show();
        }

        private void Ejercicio4Item_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio4 cap5Ejercicio4 = new Cap5Ejercicio4();
            cap5Ejercicio4.Show();
        }

        private void Ejercicio5Cap5Item_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio5 cap5Ejercicio5 = new Cap5Ejercicio5();
            cap5Ejercicio5.Show();
        }
    }
}
