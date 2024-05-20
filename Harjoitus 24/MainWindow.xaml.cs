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
using LotteryApp.Models;

namespace Harjoitus_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
    }
}



namespace LotteryApp
{
    public partial class MainWindow : Window
    {
        private Lotto _lotto = new Lotto();
        private VikingLotto _vikingLotto = new VikingLotto();
        private Eurojackpot _eurojackpot = new Eurojackpot();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ResultTextBlock.Text = "";
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedGame = (GameComboBox.SelectedItem as System.Windows.Controls.ComboBoxItem)?.Content.ToString();
            if (string.IsNullOrEmpty(selectedGame))
            {
                MessageBox.Show("Please select a game.");
                return;
            }

            switch (selectedGame)
            {
                case "Lotto":
                    var lottoRow = _lotto.GenerateRow();
                    ResultTextBlock.Text = "Lotto rivi: " + string.Join(", ", lottoRow);
                    break;

                case "Viking Lotto":
                    var vikingLottoRow = _vikingLotto.GenerateRow();
                    ResultTextBlock.Text = "Viking Lotto rivi: " + string.Join(", ", vikingLottoRow);
                    break;

                case "Eurojackpot":
                    var (mainNumbers, starNumbers) = _eurojackpot.GenerateRow();
                    ResultTextBlock.Text = "Eurojackpot pääluvut: " + string.Join(", ", mainNumbers) +
                                           "\nEurojackpot tähtinumerot: " + string.Join(", ", starNumbers);
                    break;

                default:
                    MessageBox.Show("Invalid game selection.");
                    break;
            }
        }
    }
}
