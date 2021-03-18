using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    /// <summary>
    /// Класс, хранящий результат отправки сообщения
    /// </summary>
    [DataContract]
    public class SendMessageResponse : Response
    {
        [DataMember]
        public long MessageId { get; set; }
    }
}
