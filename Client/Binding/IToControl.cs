using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Binding
{
    public interface IToControl<out U>
        where U : UserControl
    {
        U Control { get; }

        U ToControl();
    }
}
