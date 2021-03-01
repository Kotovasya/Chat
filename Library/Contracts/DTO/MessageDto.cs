using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.DTO
{
    [DataContract]
    public class MessageDto
    {
        [DataMember]
        public UserDto Author { get; set; }
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр сообщения, служащего для передачи информации о сообщении клиентам сервиса 
        /// </summary>
        /// <param name="author">Автор сообщения</param>
        /// <param name="text">Текст сообщения</param>
        public MessageDto(UserDto author, string text)
        {
            Author = author;
            Text = text;
        }
    }
}
