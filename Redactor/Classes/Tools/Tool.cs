using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Redactor.Classes.Tools
{
    public class Tool
    {
        protected bool pressed = false;
        public virtual void MouseDown(Point p)
        {

        }

        public virtual void MouseUp(Point p)
        {

        }

        public virtual void MouseMove(Point p)
        {

        }

        public virtual void MouseStop()
        {
            if (pressed)
            pressed = false;
        }
    }
}
