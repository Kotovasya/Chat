using Client.Binding;
using Client.View.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Client.Entities
{
    public class Message : IToControl<MessageControl>, INotifyPropertyChanged
    {
        private string text;
        private User author;

        public event PropertyChangedEventHandler PropertyChanged;

        public long Id { get; set; }

        public MessageControl Control { get; set; }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public User Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public Message(MessageDto messageDto)
        {
            Id = messageDto.Id;
            text = messageDto.Text;
        }

        public Message(long id, string text, User author)
        {
            Id = id;
            this.text = text;
            this.author = author;
        }

        public MessageControl ToControl()
        {
            Control = new MessageControl(this);
            return Control;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
