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
    /// <summary>
    /// Сущность сообщения, хранящиая информацию о нем и ее UI Control
    /// </summary>
    public class Message : IToControl<MessageControl>, INotifyPropertyChanged
    {
        private string text;
        private User author;
        private DateTime date;

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

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Инициализирует экзмепляр сущности из DTO сообщения
        /// </summary>
        /// <param name="messageDto">Полученное от сервера DTO сообщение</param>
        public Message(MessageDto messageDto)
        {
            Id = messageDto.Id;
            text = messageDto.Text;
            date = messageDto.Date;
        }

        /// <summary>
        /// Иницилизирует экземпляр сущности сообщения
        /// </summary>
        /// <param name="id">ID сообщения</param>
        /// <param name="text">Текст сообщения</param>
        /// <param name="author">Автор сообщения</param>
        public Message(long id, string text, User author, DateTime date)
        {
            Id = id;
            this.text = text;
            this.author = author;
            this.date = date;
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
