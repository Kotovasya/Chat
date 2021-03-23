using Client.Binding;
using Client.ServiceReference;
using Client.View.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Client.Entities
{
    public class Dialog : IToControl<DialogControl>, INotifyPropertyChanged
    {
        private string name;

        public int Id { get; set; }
        public Guid OwnerId { get; private set; }
        public SourceList<long, Message> Messages { get; private set; }
        public SourceList<Guid, User> Users { get; private set; }

        public DialogControl Control { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public Dialog(DialogDto dialog)
        {
            Id = dialog.Id;
            name = dialog.Name;
            OwnerId = dialog.OwnerId;
            Users = new SourceList<Guid, User>(dialog.Users?.ToDictionary(kvp => kvp.Key, kvp => new User(kvp.Value)));
            Messages = new SourceList<long, Message>(dialog.Messages?.ToDictionary(kvp => kvp.Key, kvp => new Message(kvp.Value)));
        }

        public DialogControl ToControl()
        {
            return new DialogControl(this);
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
