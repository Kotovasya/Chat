using Client.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entities
{
    public class DialogPreview : Entity<DialogPreviewControl>
    {
        private bool unreadMessage;
        private Message lastMessage;

        public Dialog Owner { get; set; }

        public bool UnreadMessage
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
            LastMessage = dialog.Messages.Last();
            dialog.Messages.ElementAdding += OnMessageAdded;
            dialog.Messages.ElementRemoving += OnMessageRemoved;
            CreateEditBind();
        }

        public override DialogPreviewControl ToControl()
        {
            Control = new DialogPreviewControl(Owner);
            return Control;
        }

        private void OnMessageAdded(object sender, Message message)
        {
            if (message.Id > lastMessage?.Id)
            {
                LastMessage = message;
                CreateEditBind();
            }
        }

        private void OnMessageRemoved(object sender, Message message)
        {
            if (message.Id == lastMessage.Id)
            {
                LastMessage = Owner.Messages
                    .Skip(Owner.Messages.Count - 2)
                    .First().Value;
                CreateEditBind();
            }
        }

        private void CreateEditBind()
        {
            if (lastMessage != null)
                lastMessage.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
                {
                    OnPropertyChanged("LastMessage");
                };
        }
    }
}
