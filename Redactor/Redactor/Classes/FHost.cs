using System.Windows;
using System.Windows.Media;

namespace Redactor.Classes
{
    public class FHost : FrameworkElement
    {
        public VisualCollection Children;

        public FHost()
        {
            Children = new VisualCollection(this);
        }

        protected override Visual GetVisualChild(int index)
        {
            return Children[index];
        }

        protected override int VisualChildrenCount => Children.Count;

        public void Clear()
        {
            Children.Clear();
        }
    }
}
