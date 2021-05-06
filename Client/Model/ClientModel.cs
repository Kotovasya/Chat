using Client.Binding;
using Client.Entities;
using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Model
{
    /// <summary>
    /// Модель, служащая для хранения данных с сервера
    /// </summary>
    public class ClientModel : ServiceClient, INotifyPropertyChanged
    {
        /// <summary>
        /// Экземпляр объекта, принимающий данные с сервера
        /// </summary>
        private static readonly ClientCallbacks instance = new ClientCallbacks();
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Словарь, хранящий информацию о всех диалогах
        /// </summary>
        public SourceList<int, Dialog> Dialogs { get; private set; }
        /// <summary>
        /// Словарь, хранящий информацию о всех пользователях
        /// </summary>
        public SourceList<Guid, User> Users { get; private set; }

        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public ClientModel() 
            : base(new InstanceContext(instance))
        {
            instance.Model = this;
            Dialogs = new SourceList<int, Dialog>();
            Users = new SourceList<Guid, User>();
            try
            {
                Id = Connect();
            }
            catch
            {
                Id = Guid.Empty;
            }
        }
    }
}
