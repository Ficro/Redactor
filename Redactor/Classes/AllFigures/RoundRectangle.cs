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
        public override Figure Clone()
        {
            return new RoundRectangle
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };
        }
        public RoundRectangle()
        {

        }

        public RoundRectangle(Point p) : base(p)
        {
            SelectedFill = Artist.SelectedFill.Clone();
            SelectedLine = Artist.SelectedLine.Clone();
        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }

        public override void Draw(DrawingContext dc)
        {
            var square = Point.Subtract(points[0],points[1]);

            dc.DrawRoundedRectangle(SelectedFill, SelectedLine, new Rect(points[1], square), 10.0, 10.0);
        }
    }
}
