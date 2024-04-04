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

namespace Harjoitus_15__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int henkilöauto = 0;
        private int kuormauto = 0;
        public MainWindow()
        {
            InitializeComponent();

            tbHenkilöatuo.text = henkilöauto.ToString();
            tbKuormauto.text = kuormauto.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            henkilöauto++;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kuormauto++;
            
        }
    }
}

