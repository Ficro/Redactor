using Redactor.Classes.Tools;
using System.Collections.Generic;
using Redactor.Classes.AllFigures;

namespace Redactor.Classes
{
    public static class Artist
    {
        public static List<Figure> Figures = new List<Figure>();

        public static List<Tool> Tools = new List<Tool>() { new LineTool(), new RectangleTool(), new EllipseTool()};

        public static Tool SelectedTool = Tools[1];

        public static FHost FHost = new FHost();
    }
}
