using System;
using Redactor.Classes.AllFigures;
using System.Windows;

namespace Redactor.Classes.Tools
{
    class ZoomTool : Tool
    {
        public override void MouseDown(Point point)
        {
            pressed = true;
            Artist.Figures.Add(new DashRectangle(point));
        }

        public override void MouseMove(Point p)
        {
            if (pressed)
                Artist.Figures[Artist.Figures.Count - 1].AddPoint(p);
        }
        public override void MouseStop()
        {
            if (pressed)
            {
                pressed = false;
                if (Artist.Figures.Count != 0)
                    Artist.Figures.Remove(Artist.Figures[Artist.Figures.Count -1]);
            }

        }

        public override void MouseUp(Point point)
        {
            if (Point.Subtract(Artist.Figures[Artist.Figures.Count - 1].points[0], Artist.Figures[Artist.Figures.Count - 1].points[1]).Length > 50)
            {
                Artist.ScaleRateX = Artist.CanvasWidth / Math.Abs(Artist.Figures[Artist.Figures.Count - 1].points[0].X - Artist.Figures[Artist.Figures.Count - 1].points[1].X);

                if (Artist.Figures[Artist.Figures.Count - 1].points[1].Y > Artist.Figures[Artist.Figures.Count - 1].points[0].Y)
                {
                    Artist.ScaleRateY = Artist.CanvasHeigth / (Artist.Figures[Artist.Figures.Count - 1].points[1].Y - Artist.Figures[Artist.Figures.Count - 1].points[0].Y);
                }
                else
                {
                    Artist.ScaleRateY = Artist.CanvasHeigth / (Artist.Figures[Artist.Figures.Count - 1].points[0].Y - Artist.Figures[Artist.Figures.Count - 1].points[1].Y);
                }


                if (Artist.ScaleRateX > Artist.ScaleRateY)
                {
                    Artist.ScaleRateY = Artist.ScaleRateX;
                }
                else
                {
                    Artist.ScaleRateX = Artist.ScaleRateY;
                }


                if (Artist.Figures[Artist.Figures.Count - 1].points[1].X > Artist.Figures[Artist.Figures.Count - 1].points[0].X)
                {
                    Artist.DistanceToPointX = Artist.Figures[Artist.Figures.Count - 1].points[0].X;
                }
                else
                {
                    Artist.DistanceToPointX = Artist.Figures[Artist.Figures.Count - 1].points[1].X;
                }


                if (Artist.Figures[Artist.Figures.Count - 1].points[1].Y > Artist.Figures[Artist.Figures.Count - 1].points[0].Y)
                {
                    Artist.DistanceToPointY = Artist.Figures[Artist.Figures.Count - 1].points[0].Y;
                }
                else
                {
                    Artist.DistanceToPointY = Artist.Figures[Artist.Figures.Count - 1].points[1].Y;
                }
            }
            else
            {
                Artist.ScaleRateX = 1;
                Artist.ScaleRateY = 1;
                Artist.DistanceToPointX = 0;
                Artist.DistanceToPointY = 0;
            }
            Artist.Figures.Remove(Artist.Figures[Artist.Figures.Count - 1]);

        }
    }
}


