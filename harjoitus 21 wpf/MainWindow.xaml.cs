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

namespace harjoitus_21_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
            
        
    }
}


namespace ShoppingCart
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TextBlock txtProduct = new TextBlock();
            txtProduct.Text = chk.Content.ToString();
            StockPanel.Children.Add(txtProduct);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            foreach (TextBlock txtProduct in StockPanel.Children)
            {
                if (txtProduct.Text == chk.Content.ToString())
                {
                    StockPanel.Children.Remove(txtProduct);
                    break;
                }
            }
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox chk in GetAllCheckBoxes())
            {
                chk.IsChecked = false;
            }
            StockPanel.Children.Clear();
        }

        private System.Collections.Generic.IEnumerable<CheckBox> GetAllCheckBoxes()
        {
            foreach (var child in FindVisualChildren<CheckBox>(this))
            {
                yield return child;
            }
        }

        private System.Collections.Generic.IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}

