using Redactor.Classes.Tools;
using System.Collections.Generic;
using Redactor.Classes.AllFigures;
using System.Windows.Media;

namespace Redactor.Classes
{
    public static class Artist
    {
        public static List<Figure> Figures = new List<Figure>();

        public static System.Windows.Media.Pen pen = new System.Windows.Media.Pen(Brushes.Black, 3);

        public static Pen SelectedLine = new Pen(Brushes.Black, 3);

        public static Brush SelectedFill = Brushes.White;

        public static Brush brush = new SolidColorBrush(Colors.Transparent);

        public static List<Tool> Tools = new List<Tool>() { new PolyLineTool(), new LineTool(), new EllipseTool(),  new RectangleTool(), new RoundRectangleTool(), new StarTool() };

        public static Tool SelectedTool = Tools[0];

        public static FHost FHost = new FHost();         
    }
}
