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
    /// Interaction logic for Cap5Ejercicio5.xaml
    /// </summary>
    public partial class Cap5Ejercicio5 : Window
    {
        int num;
        public Cap5Ejercicio5()
        {
            InitializeComponent();
        }

        private void convertirButton_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(NumeroTextBox.Text);
            
            ResultadoTextBox.Text = ConvertirLetra();
            
        }
        private string ConvertirLetra()
        {

            string strAlpha = "";


            for (int i = 65; i <= 90; i++) //

            {
                strAlpha += ((char)num).ToString() + " ";
            }

            return strAlpha;
        }
    }
}
