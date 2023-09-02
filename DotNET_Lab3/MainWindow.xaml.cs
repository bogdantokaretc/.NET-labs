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

namespace DotNET_Lab3
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
        private void CreateSandglassButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (double.TryParse(A.Text, out double a) && double.TryParse(B.Text, out double b))
            {
                Hourglass hourglass = new Hourglass(a, b);
                hourglass.Draw(MainCanvas);
            }
            else
            {
                MessageBox.Show("Invalid value for A");
            }
        }
        private void A_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(A.Text, out double a))
            {
                B.Text = (Math.Sqrt(3) * a).ToString("f1");
            }
        }
    }
}
