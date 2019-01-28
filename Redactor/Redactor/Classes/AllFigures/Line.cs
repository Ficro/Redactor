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
        public Line()
        {
               
        }

        public Line(Point p) : base(p)
        {
            
        }
        public override void Draw(DrawingContext dc)
        {
            dc.DrawLine(new Pen(Brushes.Black, 4), points[0], points[1]);
        }

        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
    }
}
