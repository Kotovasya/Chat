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
    /// <summary>
    /// Словарь, хранящий сущности и служащий для уведомления UI об их изменениях
    /// </summary>
    /// <typeparam name="TKey">Ключ (ID) сущности</typeparam>
    /// <typeparam name="TValue">Сущность</typeparam>
    public class SourceList<TKey, TValue> : IDictionary<TKey, TValue>
        where TKey : IEquatable<TKey>
        where TValue : IToControl<UserControl>, INotifyPropertyChanged
    {
        private readonly Dictionary<TKey, TValue> entites;
        private Control.ControlCollection collection;

        /// <summary>
        /// Событие, возникающее при удалении UI Control'a сущности
        /// </summary>
        public EventHandler<ControlEventArgs> ControlRemoving;
        /// <summary>
        /// Событие, возникающее при изменении размеров UI Control'a сущности
        /// </summary>
        public EventHandler<ControlEventArgs> ControlSizeChanged;

        /// <summary>
        /// Коллекция, хранящая UI Controls сущностей. При наличии сущностей в словаре, добавляет их UI Control в установленную коллекцию
        /// </summary>
        public Control.ControlCollection Collection
        {
            get { return collection; }
            set 
            { 
                collection = value;
                foreach (var kvp in entites)
                    AddControl(kvp.Value);
            }
        }

        public TValue this[TKey key]
        {
            get => entites[key];
        }

        /// <summary>
        /// Инициализирует экземпляр словаря, без привязки к коллекции Controls
        /// </summary>
        public SourceList()
        {
            entites = new Dictionary<TKey, TValue>();
        }

        /// <summary>
        /// Добавляет новую сущность в словарь, а так же, при наличии привязки к ControlsCollection, добавляет ее UI Control в коллекцию
        /// </summary>
        /// <param name="key">Ключ (ID) сущности</param>
        /// <param name="value">Экземпляр сущности</param>
        public void Add(TKey key, TValue value)
        {
            if (collection != null)
                AddControl(value);
            entites.Add(key, value);
        }

        /// <summary>
        /// Добавляет UI Control сущности в ControlCollection
        /// </summary>
        /// <param name="value"></param>
        private void AddControl(TValue value)
        {
            UserControl control = value.ToControl();
            control.SizeChanged += Control_SizeChanged;
            Collection?.Add(control);
        }

        /// <summary>
        /// Удаляет сущность и ее UI Control по ее ключу в словаре. Возвращает false, если сущности в словари нет, иначе true
        /// </summary>
        /// <param name="key">Ключ (ID) сущности</param>
        /// <returns>Результат удаления сущности</returns>
        public bool Remove(TKey key)
        {
            ControlRemoving?.Invoke(this, new ControlEventArgs(entites[key].Control));
            if (Collection != null && Collection.Contains(entites[key].Control))
                Collection.Remove(entites[key].Control);
            return entites.Remove(key);
        }

        /// <summary>
        /// Возвращает последнюю добавленную сущность в словарь
        /// </summary>
        /// <returns>Последння добавленная сущность в словаре</returns>
        public TValue Last()
        {
            return entites.Any() ? entites.Last().Value : default;
        }

        /// <summary>
        /// Обработчик события, вызывающийся при изменении размеров одного из UI Control в коллекции
        /// </summary>
        /// <param name="sender">UI Control, вызвавший изменения</param>
        /// <param name="e">Аргументы события</param>
        private void Control_SizeChanged(object sender, EventArgs e)
        {
            ControlSizeChanged?.Invoke(sender, new ControlEventArgs((Control)sender));
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
