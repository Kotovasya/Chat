using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    /// <summary>
    /// Класс запроса для авторизации
    /// </summary>
    [DataContract]
    public class AuthRequest : Request
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        [DataMember]
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [DataMember]
        public string Password { get; set; }
    }
}
