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

namespace Harjoitus_18_wpf 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Summa_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = Convert.ToDouble(txtBox_Numero1.Text);
            double numero2 = Convert.ToDouble(txtBox_Numero2.Text);


            double tulos = numero1 + numero2;


            txtBlock_Tulos.Text = tulos.ToString();
        }

        private void btn_Erotus_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = Convert.ToDouble(txtBox_Numero1.Text);
            double numero2 = Convert.ToDouble(txtBox_Numero2.Text);
            double tulos = numero1 - numero2;
            txtBlock_Tulos.Text = tulos.ToString();
        }

        private void btn_Kertolasku_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = Convert.ToDouble(txtBox_Numero1.Text);
            double numero2 = Convert.ToDouble(txtBox_Numero2.Text);
            double tulos = numero1 * numero2;
            txtBlock_Tulos.Text = tulos.ToString();
        }

        private void btn_Jakolasku_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = Convert.ToDouble(txtBox_Numero1.Text);
            double numero2 = Convert.ToDouble(txtBox_Numero2.Text);


            if (numero2 != 0)
            {
                double tulos = numero1 / numero2;
                txtBlock_Tulos.Text = tulos.ToString();
            }
            else
            {
                MessageBox.Show("Nollalla ei voi jakaa!");
            }
        }
    }
}

