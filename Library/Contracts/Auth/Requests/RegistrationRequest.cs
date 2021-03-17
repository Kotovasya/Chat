using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    /// <summary>
    /// Класс запроса для регистрации нового пользователя
    /// </summary>
    [DataContract]
    public class RegistrationRequest : Request
    {
        /// <summary>
        /// Имя нового пользователя
        /// </summary>
        [DataMember]
        public string Login { get; set; }
        /// <summary>
        /// Пароль нового пользователя
        /// </summary>
        [DataMember]
        public string Password { get; set; }
    }
}
