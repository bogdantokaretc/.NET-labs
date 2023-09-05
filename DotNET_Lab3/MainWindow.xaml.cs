using System;
using System.Windows;
using System.Windows.Input;

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
