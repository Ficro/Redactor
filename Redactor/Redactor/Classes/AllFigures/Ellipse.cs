using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    public class Ellipse: Figure
    {
        public Ellipse(Point p) : base(p)
        {

        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
        public override void Draw(DrawingContext dc)
        {
            var space = Vector.Divide(Point.Subtract(points[0], points[1]), 2.0);
            var center = Point.Add(points[1], space);

            dc.DrawEllipse(Artist.brush, Artist.pen, center, space.X, space.Y);
        }
    }
}
