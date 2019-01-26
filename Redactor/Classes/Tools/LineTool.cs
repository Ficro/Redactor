using Redactor.Classes.AllFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Redactor.Classes.Tools
{
    class LineTool : Tool
    {
        public override void MouseDown(Point p)
        {
            Artist.Figures.Add(new Line(p));
        }

        public override void MouseMove(Point p)
        {
            Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }

        public override void MouseUp(Point p)
        {
            //base.MouseUp(p);
        }
    }
}
