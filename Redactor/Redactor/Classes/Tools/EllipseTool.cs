using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redactor.Classes.AllFigures;
using System.Windows;

namespace Redactor.Classes.Tools
{
    class EllipseTool: Tool
    {
        public override void MouseDown(Point p)
        {
            Artist.Figures.Add(new Ellipse(p));
        }

        public override void MouseMove(Point p)
        {
            Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }
    }
}
