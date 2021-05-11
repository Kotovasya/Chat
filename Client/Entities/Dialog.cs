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
using Client.Model;

namespace Client.Entities
{
    public class Dialog : Entity<DialogControl>
    {
        private string name;

        public int Id { get; set; }
        public Guid OwnerId { get; private set; }
        public SourceList<long, Message> Messages { get; private set; }
        public SourceList<Guid, User> Users { get; private set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool AllMessagesLoad { get; private set; }

        public DialogPreview Preview { get; set; }

        public Dialog(DialogDto dialog)
        {
            Id = dialog.Id;
            name = dialog.Name;
            OwnerId = dialog.OwnerId;
            Users = new SourceList<Guid, User>(dialog.Users?.ToDictionary(u => u.Id, u => new User(u)));
            Messages = new SourceList<long, Message>(dialog.Messages?.ToDictionary(m => m.Id, m => 
            new Message(m.Id, m.DialogId, m.Text, Users[m.Author.Id], m.Date)));
            Preview = new DialogPreview(this);
        }

        public override DialogControl ToControl()
        {
            Control = new DialogControl(this);
            return Control;
        }

        //Костыль который я отказался фиксить из-за сроков
        public DialogControl ToControl(ClientModel model)
        {
            Control = new DialogControl(this, model);
            return Control;
        }

        public void LoadMessages(LoadMessagesResponse response)
        {

            if (response.Result == Result.AllLoad)
                AllMessagesLoad = true;
            foreach (var message in response.Messages)
                Messages.Add(message.Id, new Message(message.Id, message.DialogId, message.Text, Users[message.Author.Id], message.Date));            
        }
    }
}
