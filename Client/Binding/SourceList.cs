using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Client.Binding
{
    public class SourceList<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
        where TKey : IEquatable<TKey>
        where TValue : IToControl<UserControl>, INotifyPropertyChanged
    {
        private readonly Dictionary<TKey, TValue> entites;
        private readonly Control.ControlCollection collection;

        public EventHandler<ControlEventArgs> ControlRemoving;
        public EventHandler<ControlEventArgs> ControlSizeChanged;

        public TValue this[TKey key]
        {
            get { return entites[key]; }
        }

        public SourceList(Control.ControlCollection collection)
        {
            entites = new Dictionary<TKey, TValue>();
            this.collection = collection;
        }

        public void Add(TKey key, TValue value)
        {
            UserControl control = value.ToControl();
            control.SizeChanged += Control_SizeChanged;
            collection.Add(control);
            entites.Add(key, value);
        }

        private void Control_SizeChanged(object sender, EventArgs e)
        {
            ControlSizeChanged?.Invoke(sender, new ControlEventArgs((UserControl)sender));
        }

        public bool Remove(TKey key)
        {
            ControlRemoving?.Invoke(this, new ControlEventArgs(entites[key].Control));
            collection.Remove(entites[key].Control);
            return entites.Remove(key);
        }

        public TValue Last()
        {
            return entites.Any() ? entites.Last().Value : default;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return entites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
