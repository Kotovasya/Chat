using Client.Binding;
using Client.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entities
{
    /// <summary>
    /// Сущность пользователя, хранящая информацию о нем и ее UI Control
    /// </summary>
    public class User : Entity<ClientControl>
    {
        private Guid id;
        private string name;
        private bool online;

        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid Id
        {
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Хранит значение, обозначающее, находится ли пользователь в сети в данный момент времени
        /// </summary>
        public bool Online
        {
            get { return online; }
            set
            {
                online = value;
                OnPropertyChanged("Online");
            }
        }

        /// <summary>
        /// Иницилизурет экземпляр пользователя из DTO, полученный от сервера
        /// </summary>
        /// <param name="user">Data Transfer Object пользователя</param>
        public User(ServiceReference.UserDto user)
            : this(user.Id, user.Name, true)
        { }

        /// <summary>
        /// Иницилизрует экземпляр пользователя
        /// </summary>
        /// <param name="id">ID пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="isOnline">Флаг, определяющий находится ли пользователь в сети</param>
        public User(Guid id, string name, bool isOnline)
        {
            this.id = id;
            this.name = name;
            online = isOnline;
        }

        public override ClientControl ToControl()
        {
            Control = new ClientControl(this);
            return Control;
        }
    }
}
