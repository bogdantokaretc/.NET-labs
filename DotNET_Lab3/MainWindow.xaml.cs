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
                DrawSandglass(a, b);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення A і B.");
            }
        }

        private void DrawSandglass(double a, double b)
        {
            MainCanvas.Children.Clear();

            Point p1 = new Point(50, 50);
            Point p2 = new Point(50 + a, 50);
            Point p3 = new Point(50 + a / 2, 50 + Math.Sqrt(3) * a / 2);

            Point p4 = new Point(50, 50 + b);
            Point p5 = new Point(50 + a, 50 + b);
            Point p6 = new Point(50 + a / 2, 50 + b - Math.Sqrt(3) * a / 2);

            Polygon triangle1 = new Polygon
            {
                Points = new PointCollection { p1, p2, p3 },
                Fill = Brushes.Blue
            };

            Polygon triangle2 = new Polygon
            {
                Points = new PointCollection { p4, p5, p6 },
                Fill = Brushes.Red
            };

            MainCanvas.Children.Add(triangle1);
            MainCanvas.Children.Add(triangle2);
        }
    }
    public class Hourglass
    {
        private double a;
        private double b;

        public Hourglass(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Hourglass() : this(0, 0)
        {
        }
    }
}
