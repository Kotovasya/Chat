using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    /// <summary>
    /// Представляет данные для события отправки сообщения
    /// </summary>
    [DataContract]
    public class MessageSendEventArgs : ServerEventArgs
    {
        /// <summary>
        /// Отправленное сообщение
        /// </summary>
        [DataMember]
        public MessageDto Message { get; set; }
        
        public MessageSendEventArgs(Guid id, MessageDto message) 
            : base(id)
        {
            Message = message;
        }
    }
}
