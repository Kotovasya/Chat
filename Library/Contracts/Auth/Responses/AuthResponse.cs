using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    /// <summary>
    /// Класс хранящий результат выполнения авторизации
    /// </summary>
    [DataContract]
    public class AuthResponse : Response
    {
        /// <summary>
        /// ID пользователя, полученный из базы данных
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
    }
}
