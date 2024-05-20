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

namespace Harjoitus_22_wpf
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


namespace WindowAreaCalculator
{
    public partial class MainWindow : Window
    {
       
        
           
        

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text) / 10; 
                double height = double.Parse(txtHeight.Text) / 10; 
                double frameWidth = double.Parse(txtFrameWidth.Text) / 10; 

                
                double framePerimeter = 2 * (width + height);
                double glassArea = (width - 2 * frameWidth) * (height - 2 * frameWidth);
                double windowArea = width * height;

                
                lblFramePerimeter.Content = "{framePerimeter:F2} cm";
                lblGlassArea.Content = "{glassArea:F2} cm²";
                lblWindowArea.Content = "{windowArea:F2} cm²";
            }
            catch (FormatException)
            {
                MessageBox.Show("Syötä kelvolliset arvot leveydelle, korkeudelle ja karmipuun leveydelle.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe laskennassa: {ex.Message}");
            }
        }
    }
}
