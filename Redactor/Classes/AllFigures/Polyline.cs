using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows;
using Redactor.Classes.AllFigures;
namespace Redactor.Classes.AllFigures
{
    class Polyline : Figure
    {
        public override Figure Clone()
        {
            return new Polyline
            {
                points = new List<Point>(points),
                SelectedFill = this.SelectedFill,
                SelectedLine = this.SelectedLine
            };
        }
        
        public Polyline()
        {

        }
        
        public Polyline(Point p) : base(p)
        {
            SelectedLine = Artist.SelectedLine.Clone();
        }
        public override void AddPoint(Point p)
        {
            points.Add(p);
        }
        public override void Draw(DrawingContext dc)
        {
            var geo = new StreamGeometry();
            using (var geoContext = geo.Open())
            {
                geoContext.BeginFigure(points[0], false, false);
                geoContext.PolyLineTo(points, true, false);
            }
            dc.DrawGeometry(null, SelectedLine, geo);

        }
    }
}
