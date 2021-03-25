using Client.Binding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Entities
{
    public abstract class Entity<T> : IToControl<T>, INotifyPropertyChanged
        where T : UserControl
    {
        public T Control { get; set;}

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract T ToControl();

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
