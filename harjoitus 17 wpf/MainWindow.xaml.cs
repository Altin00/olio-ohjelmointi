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

namespace harjoitus_17_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// ¨Käytetty chatgpt apuna
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiönValot = false;
        bool olohuoneenValot = false;
        bool oviLukossa = true;

        public MainWindow()
        {
            InitializeComponent();
            PäivitäTilat();
        }

        private void PäivitäTilat()
        {
            tb_Lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            tb_KeittiöTila.Text = keittiönValot.ToString();
            tb_OlohuoneTila.Text = olohuoneenValot.ToString();
            btn_Ovi.Content = oviLukossa.ToString();
        }

        private void btn_Olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;
            PäivitäTilat();
        }

        private void btn_Keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiönValot = !keittiönValot;
            PäivitäTilat();
        }

        private void btn_Ovi_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
            PäivitäTilat();
        }

        private void txt_Termostaatti_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Termostaatti.Text, "[^0-9]"))
            {
                MessageBox.Show("Numeroita");
                txt_Termostaatti.Text = "";
            }
            else
            {
                if (txt_Termostaatti.Text == "")
                    return;

                lämpötila = float.Parse(txt_Termostaatti.Text);
                PäivitäTilat();
            }
        }
    }
}


