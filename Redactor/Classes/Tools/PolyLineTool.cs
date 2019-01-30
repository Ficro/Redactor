using Redactor.Classes.AllFigures;
using System.Windows;


namespace Redactor.Classes.Tools
{
    class PolyLineTool: Tool
    {
        public override void MouseDown(Point p)
        {
            Artist.Figures.Add(new Polyline(p));
        }

        public override void MouseMove(Point p)
        {
                Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }

        public override void MouseUp(Point p)
        {
           
        }
    }
}
