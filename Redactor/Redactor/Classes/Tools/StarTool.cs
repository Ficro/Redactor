using Redactor.Classes.AllFigures;
using System.Windows;

namespace Redactor.Classes.Tools
{
    class StarTool : Tool
    {
        public override void MouseDown(Point p)
        {
            Artist.Figures.Add(new Star(p));
        }

        public override void MouseMove(Point p)
        {
            Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }
    }
}
