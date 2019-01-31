using Redactor.Classes;
using Redactor.Classes.AllFigures;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace Redactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            MainCanvas.Children.Add(Artist.FHost);

            Brush[] colors =             
            {
                Brushes.Maroon,Brushes.Crimson,Brushes.DeepPink,Brushes.Fuchsia,Brushes.DarkOrange,Brushes.Orange,Brushes.Yellow,Brushes.Lime,Brushes.Green,Brushes.Teal,
                Brushes.Aqua,Brushes.Blue,Brushes.Navy,Brushes.BlueViolet,Brushes.Indigo,Brushes.Black,Brushes.Gray,Brushes.White,

            };

            int j = 0;
            foreach (var brush in colors)    
            {
                Button newButton = new Button()
                {
                    Width = 30,
                    Height = 30,
                    Background = brush,
                    Tag = brush
                };
                newButton.SetValue(Grid.RowProperty, j);
                newButton.SetValue(Grid.ColumnProperty, 1);
                j++;
                newButton.Click += new RoutedEventHandler(ButtonFill_Click);
                Palette.Children.Add(newButton);

            }

            j = 0;
            foreach (var brush in colors)     
            {
                Button newButton = new Button()
                {
                    Width = 30,
                    Height = 30,
                    Background = brush,
                    Tag = brush
                };
                newButton.SetValue(Grid.ColumnProperty, 0);
                newButton.SetValue(Grid.RowProperty, j);
                j++;
                newButton.Click += new RoutedEventHandler(ButtonLine_Click);
                Palette.Children.Add(newButton);

            }
        }

        private void ButtonFill_Click(object sender, RoutedEventArgs e)
        {
            Artist.SelectedFill = (sender as Button).Tag as Brush;
        }
        private void ButtonLine_Click(object sender, RoutedEventArgs e)
        {
            Artist.SelectedLine = new Pen((sender as Button).Background, 2.0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Classes.Artist.SelectedTool = Classes.Artist.Tools[Convert.ToInt32((sender as Button).Tag)];
        }

        private void MainCanvasMouseDown(object sender, MouseButtonEventArgs e)
        {
            Artist.SelectedTool.MouseDown(e.GetPosition(MainCanvas));
            Invalidate();
        }

        private void MainCanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Artist.SelectedTool.MouseMove(e.GetPosition(MainCanvas));
                Invalidate();
            }
        }

        private void Invalidate()
        {
            Artist.FHost.Clear();
            var dv = new DrawingVisual();
            var dc = dv.RenderOpen();
            foreach (Figure f in Artist.Figures)
            {
                f.Draw(dc);
            }
            dc.Close();
            Artist.FHost.Children.Add(dv);
        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Artist.SelectedTool.MouseStop();
            Invalidate();
        }

        private void MainCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            Artist.CanvasHeigth = MainCanvas.ActualHeight;
            Artist.CanvasWidth = MainCanvas.ActualWidth;
        }

        private void MainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Artist.CanvasHeigth = MainCanvas.ActualHeight;
            Artist.CanvasWidth = MainCanvas.ActualWidth;
        }

        private void MainCanvasMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Artist.SelectedTool != Artist.Tools[6])
                Artist.AddCondition();
            Artist.SelectedTool.MouseUp(e.GetPosition(MainCanvas));
            if (Artist.SelectedTool == Artist.Tools[6])
            {
                MainCanvas.LayoutTransform = new ScaleTransform(Artist.ScaleRateX, Artist.ScaleRateY);
                ScrollCanvas.ScrollToVerticalOffset(Artist.DistanceToPointY * Artist.ScaleRateY);
                ScrollCanvas.ScrollToHorizontalOffset(Artist.DistanceToPointX * Artist.ScaleRateX);
            }
            Invalidate();
        }
    }
}
