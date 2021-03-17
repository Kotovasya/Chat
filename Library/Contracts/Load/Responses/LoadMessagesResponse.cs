using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Load
{
    /// <summary>
    /// Класс, хранящий результат выполнения загрузки сообщений
    /// </summary>
    [DataContract]
    public class LoadMessagesResponse : Response
    {
        /// <summary>
        /// Загруженные сообщения
        /// </summary>
        [DataMember]
        public ICollection<MessageDto> Messages { get; set; }
    }
}
