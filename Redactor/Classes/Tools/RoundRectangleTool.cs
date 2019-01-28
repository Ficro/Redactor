using System.Windows;
using Redactor.Classes.AllFigures;

namespace Redactor.Classes.Tools
{
    class RoundRectangleTool : Tool
    {
        public override void MouseDown(Point p)
        {
            Artist.Figures.Add(new RoundRectangle(p));
        }

        public override void MouseMove(Point p)
        {
                Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }

   
    }
}
