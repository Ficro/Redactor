using System.Windows;
using System.Windows.Media;
using System.Collections.Generic;

namespace Redactor.Classes.AllFigures
{
    public class Rectangle : Figure
    {
        public override Figure Clone()
        {
            return new Rectangle
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };
        }
        public Rectangle()
        {

        }
        public Rectangle(Point p) : base(p)
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
            dc.DrawRectangle(SelectedFill, SelectedLine, new Rect(points[0], points[1]));
        }
    }
}
