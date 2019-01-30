﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes.AllFigures
{
    public class Rectangle : Figure
    {
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
