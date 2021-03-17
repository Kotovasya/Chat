using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    /// <summary>
    /// Класс, хранящий результат выполнения регистрации нового пользователя
    /// </summary>
    [DataContract]
    public class RegistrationResponse : Response
    {
        /// <summary>
        /// ID нового пользователя
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
    }
}
