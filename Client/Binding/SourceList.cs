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
    public class SourceList<TKey, TValue> : IDictionary<TKey, TValue>
        where TKey : IEquatable<TKey>
        where TValue : IToControl<UserControl>, INotifyPropertyChanged
    {
        private readonly Dictionary<TKey, TValue> entites;

        public EventHandler<ControlEventArgs> ControlRemoving;
        public EventHandler<ControlEventArgs> ControlSizeChanged;

        public Control.ControlCollection Collection { get; set; }

        public TValue this[TKey key]
        {
            get => entites[key];
        }

        public SourceList()
        {
            entites = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            UserControl control = value.ToControl();
            control.SizeChanged += Control_SizeChanged;
            Collection?.Add(control);
            entites.Add(key, value);
        }

        private void Control_SizeChanged(object sender, EventArgs e)
        {
            ControlSizeChanged?.Invoke(sender, new ControlEventArgs((UserControl)sender));
        }

        public bool Remove(TKey key)
        {
            ControlRemoving?.Invoke(this, new ControlEventArgs(entites[key].Control));
            Collection?.Remove(entites[key].Control);
            return entites.Remove(key);
        }

        public TValue Last()
        {
            return entites.Any() ? entites.Last().Value : default;
        }

        #region IDictionary realization

        TValue IDictionary<TKey, TValue>.this[TKey key]
        {
            get => entites[key];
            set => entites[key] = value;
        }

        public ICollection<TKey> Keys => entites.Keys;

        public ICollection<TValue> Values => entites.Values;

        public int Count => entites.Count;

        public bool IsReadOnly => true;

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return entites.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            entites.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return entites.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return entites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
