using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    /// <summary>
    /// Абстрактный класс запросов, служащий для наследования классов хранящих данные, передаваемые клиентом сервису
    /// </summary>
    [DataContract]
    public abstract class Request
    {
        /// <summary>
        /// ID клиента, от которого был направлен запрос
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
    }
}