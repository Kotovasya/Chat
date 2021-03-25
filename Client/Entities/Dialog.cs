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
    public class Dialog : Entity<DialogControl>
    {
        public class DialogPreview : Entity<DialogPreviewControl>
        {
            private bool unreadMessage;
            private Message lastMessage;

            public Dialog Owner { get; set; }

            public bool UnreadMessages
            {
                get { return unreadMessage; }
                set
                {
                    unreadMessage = value;
                    OnPropertyChanged("UnreadMessage");
                }
            }

            public Message LastMessage
            {
                get { return lastMessage; }
                set
                {
                    lastMessage = value;
                    OnPropertyChanged("LastMessage");
                }
            }

            public DialogPreview(Dialog dialog)
            {
                Owner = dialog;
            }

            public override DialogPreviewControl ToControl()
            {
                return new DialogPreviewControl(Owner);
            }
        }

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

        public DialogPreview Preview { get; set; }
        
        public Dialog(DialogDto dialog)
        {
            Id = dialog.Id;
            name = dialog.Name;
            OwnerId = dialog.OwnerId;
            Users = new SourceList<Guid, User>(dialog.Users?.ToDictionary(kvp => kvp.Key, kvp => new User(kvp.Value)));
            Messages = new SourceList<long, Message>(dialog.Messages?.ToDictionary(kvp => kvp.Key, kvp => new Message(kvp.Value)));
            Preview = new DialogPreview(this);
        }

        public override DialogControl ToControl()
        {
            Control = new DialogControl(this);
            return Control;
        }
    }
}
