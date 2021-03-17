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

        public event PropertyChangedEventHandler PropertyChanged;

        public ClientControl Control { get; set; }

        public User(ServiceReference.UserDto user)
        {
            id = user.Id;
            name = user.Name;
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
