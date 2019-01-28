using Redactor.Classes.AllFigures;
using System.Windows;

namespace Redactor.Classes.Tools
{
    class LineTool : Tool
    {
        private bool Pressed = false;

        public override void MouseDown(Point p)
        {
            Pressed = true;
            Artist.Figures.Add(new Line(p));
        }

        public override void MouseMove(Point p)
        {
            if (Pressed)
            Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }

        public override void MouseUp(Point p)
        {
            Pressed = false;
        }
    }
}
