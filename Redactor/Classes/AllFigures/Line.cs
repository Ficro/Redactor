using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    class Line : Figure
    {
        public override Figure Clone()
        {
            return new Line
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };
        }
        public Line()
        {
            
        }

        public Line(Point p) : base(p)
        {
            SelectedLine = Artist.SelectedLine.Clone();
        }
        public override void Draw(DrawingContext dc)
        {
            dc.DrawLine(SelectedLine, points[0], points[1]);
        }

        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
    }
}
