using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace Redactor.Classes.AllFigures
{
    public class Figure
    {
        protected List<Point> points = new List<Point>();

        public Figure()
        {

        }

        public Figure(Point point)
        {
            points = new List<Point> { point, point };
        }

        public virtual void AddPoint(Point p)
        {

        }

        public virtual void Draw(DrawingContext dc)
        {

        }
    }
}
