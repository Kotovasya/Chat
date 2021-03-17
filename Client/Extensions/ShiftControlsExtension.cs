using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Extensions
{
    public static class ShiftControlsExtension
    {
        public static void ControlRemove(this Control.ControlCollection collection, ControlEventArgs e)
        {
            int index = collection.IndexOf(e.Control);
            for (int i = index; i < collection.Count; i++)
            {
                var control = collection[i];
                control.Location = new Point(control.Location.X, control.Location.Y - e.Control.Height);
            }
        }
    }
}
