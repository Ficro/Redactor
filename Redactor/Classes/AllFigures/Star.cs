using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    class Star: Figure
    {
        public override Figure Clone()
        {
            return new Star
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };
        }
        public Star()
        {

        }

        public Star(Point p) : base(p)
        {
            SelectedFill = Artist.SelectedFill.Clone();
            SelectedLine = Artist.SelectedLine.Clone();
        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
        public override void Draw(DrawingContext kt)
        {
            var n = 10;
            var geometry = new StreamGeometry();
            var size = Point.Subtract(points[0], points[1]);
            size = size / 2;
            var point0 = Point.Subtract(points[0], size);
            var star_pts = new List<Point>
            {
                Point.Add(point0, new Vector(size.X / 5 * 2 * Math.Sin((Math.PI / 180) * (360 / n)), size.Y / 5 * 2 * Math.Cos((Math.PI / 180) * (360 / n))))
            };

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                    star_pts.Add(Point.Add(point0, new Vector(size.X / 5 * 2 * Math.Sin((2 * Math.PI / n) * (i + 1)), size.Y / 5 * 2 * Math.Cos((2 * Math.PI / n) * (i + 1)))));
                else
                    star_pts.Add(Point.Add(point0, new Vector(size.X * Math.Sin((2 * Math.PI / n) * (i + 1)), size.Y * Math.Cos((2 * Math.PI / n) * (i + 1)))));
            }

            using (StreamGeometryContext ctx = geometry.Open())
            {
                ctx.BeginFigure(star_pts[0], true, true);
                for (int i = 1; i < n; i++)
                {
                    ctx.LineTo(star_pts[i], true, false);
                }
            }
            geometry.Freeze();
            kt.DrawGeometry(SelectedFill, SelectedLine, geometry);
        }
    }
}
