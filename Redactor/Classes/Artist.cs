using Redactor.Classes.Tools;
using System.Collections.Generic;
using Redactor.Classes.AllFigures;
using System.Windows.Media;
using System.Windows;

namespace Redactor.Classes
{
    public static class Artist
    {
        public static List<Figure> Figures = new List<Figure>();

        public static System.Windows.Media.Pen pen = new System.Windows.Media.Pen(Brushes.Black, 3);

        public static Pen SelectedLine = new Pen(Brushes.Black, 3);

        public static Brush SelectedFill = Brushes.White;

        public static Brush brush = new SolidColorBrush(Colors.Transparent);

        public static List<Tool> Tools = new List<Tool>() { new PolyLineTool(), new LineTool(), new EllipseTool(),  new RectangleTool(), new RoundRectangleTool(), new StarTool(), new ZoomTool() };

        public static Tool SelectedTool = Tools[0];

        public static FHost FHost = new FHost();

        public static double ScaleRateX = 1;

        public static double ScaleRateY = 1;

        public static double DistanceToPointX;

        public static double DistanceToPointY;

        public static double HandScrollX;

        public static double HandScrollY;

        public static double CanvasWidth;

        public static double CanvasHeigth;

        public static List<List<Figure>> ConditionsCanvas = new List<List<Figure>>();

        public static int ConditionNumber = 0;

        public static void AddCondition()
        {
            List<Figure> figuresNow = new List<Figure>();
            foreach (Figure figure in Figures)
            {
                figuresNow.Add(figure.Clone());
            }
            ConditionsCanvas.Add(figuresNow);
            ConditionNumber++;
            if (ConditionNumber != ConditionsCanvas.Count)
            {
                ConditionsCanvas.RemoveRange(ConditionNumber - 1, ConditionsCanvas.Count - ConditionNumber);
            }
            Figures.Clear();
            foreach (Figure figure in figuresNow)
            {
                Figures.Add(figure.Clone());
            }
        }
    }
}
