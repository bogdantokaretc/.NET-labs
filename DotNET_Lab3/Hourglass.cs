using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DotNET_Lab3
{
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
        public void Draw(Canvas canvas)
        {
            canvas.Children.Clear();
            Point p0 = new Point(canvas.Width / 2, canvas.Height / 2);

            Point p1 = new Point(p0.X - a / 2, p0.Y - Math.Sqrt(3) * a / 2);
            Point p2 = new Point(p0.X + a / 2, p0.Y - Math.Sqrt(3) * a / 2);

            Point p3 = new Point(p0.X - a / 2, p0.Y + Math.Sqrt(3) * a / 2);
            Point p4 = new Point(p0.X + a / 2, p0.Y + Math.Sqrt(3) * a / 2);


            Polygon upperTriangle = new Polygon
            {
                Points = new PointCollection { p0, p1, p2 },
                Fill = Brushes.Blue
            };
            Polygon lowerTriangle = new Polygon
            {
                Points = new PointCollection { p0, p3, p4 },
                Fill = Brushes.Yellow
            };

            canvas.Children.Add(upperTriangle);
            canvas.Children.Add(lowerTriangle);
        }
    }
    
}
