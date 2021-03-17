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
    public class User : IToControl<ClientControl>, INotifyPropertyChanged
    {
        private Guid id;
        private string name;
        private bool online;

        public Guid Id
        {
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool Online
        {
            get { return online; }
            set
            {
                online = value;
                OnPropertyChanged("Online");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ClientControl Control { get; set; }

        public User(ServiceReference.UserDto user)
            : this(user.Id, user.Name, true)
        { }

        public User(Guid id, string name, bool isOnline)
        {
            this.id = id;
            this.name = name;
            online = isOnline;
        }

        public ClientControl ToControl()
        {
            Control = new ClientControl(this);
            return Control;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
