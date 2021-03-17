using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.DTO
{
    /// <summary>
    /// Класс, хранящий информацию о сообщении и служащий для передачи этой информации клиентам сервиса
    /// </summary>
    [DataContract]
    public class MessageDto
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public UserDto Author { get; set; }
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр сообщения, служащего для передачи информации о сообщении клиентам сервиса 
        /// </summary>
        /// <param name="author">Автор сообщения</param>
        /// <param name="text">Текст сообщения</param>
        public MessageDto(long id, UserDto author, string text)
        {
            Id = id;
        }

        public MessageDto(UserDto author, string text)
        {
            Author = author;
            Text = text;
        }
    }
}
