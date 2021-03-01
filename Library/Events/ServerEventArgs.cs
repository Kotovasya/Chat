using Library.Events.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Events
{
    /// <summary>
    /// Представляет базовый класс для классов, содержащих данные серверных событий
    /// </summary>
    [DataContract]
    public class ServerEventArgs : EventArgs 
    {
        /// <summary>
        /// ID клиента, вызвавшего событие
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        public ServerEventArgs(Guid id)
        {
            Id = id;
        }

    }
}
