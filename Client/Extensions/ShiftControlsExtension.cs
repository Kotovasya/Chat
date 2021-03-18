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
            for (int i = index; i < collection.Count; i++)
                control.Location = new Point(collection[i].Location.X, collection[i].Location.Y - control.Height);    
        }
    }
}
