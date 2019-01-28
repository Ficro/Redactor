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
    }
}
