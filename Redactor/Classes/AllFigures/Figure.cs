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
        public List<Point> points = new List<Point>();

        public Figure()
        {

        }

        public virtual Figure Clone()
        {
            return new Figure();
            
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
        public Brush SelectedFill { get; set; }
        public Pen SelectedLine;
    }
}
