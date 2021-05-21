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
        /// <summary>
        /// Удаляет Control из коллекции, передвигая остальные
        /// </summary>
        /// <param name="collection">Коллекция, из которой удаляется Control</param>
        /// <param name="control">Удаляемый Control</param>
        public static void ControlRemove(this Control.ControlCollection collection, Control control)
        {
            int index = collection.IndexOf(control);
            for (int i = index + 1; i < collection.Count; i++)
            {
                Point newPoint = new Point(collection[i].Location.X, collection[i].Location.Y - control.Height);
                if (collection[i].InvokeRequired)
                    collection[i].BeginInvoke((Action)delegate { collection[i].Location = newPoint; });
                else
                    collection[i].Location = newPoint;
            }
            Point[] points = new Point[collection.Count - 1];
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] != control)
                    points[i] = collection[i].Location;
            }
            collection.Remove(control);
            for (int i = 0; i < collection.Count; i++)
                collection[i].Location = points[i];
        }
    }
}
