using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    class DashRectangle: Figure
    {
        public DashRectangle()
        {

        }
        public DashRectangle(Point p) : base(p)
        {

        }

        public override Figure Clone()
        {
            return new DashRectangle
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };

        }

        public override void Draw(DrawingContext drawingContext)
        {
            var diagonal = Point.Subtract(points[0], points[1]);
            drawingContext.DrawRectangle(null, new Pen(Brushes.Black, 2) { DashStyle = DashStyles.Dash }, new Rect(points[1], diagonal));
        }

        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
    }
}
