using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    class RoundRectangle : Figure
    {
        public RoundRectangle(Point p) : base(p)
        {
        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }

        public override void Draw(DrawingContext dc)
        {
            var square = Point.Subtract(points[0],points[1]);

            dc.DrawRoundedRectangle(Artist.brush, Artist.pen, new Rect(points[1], square), 10.0, 10.0);
        }
    }
}
