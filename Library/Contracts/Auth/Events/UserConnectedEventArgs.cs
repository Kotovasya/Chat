using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    /// <summary>
    /// Содержит данные о событии, вызванного авторизацией пользователя
    /// </summary>
    [DataContract]
    public class UserConnectedEventArgs : ServerEventArgs
    {
        /// <summary>
        /// Авторизованный пользователь, вызвавший событие
        /// </summary>
        [DataMember]
        public UserDto User { get; set; }

        public UserConnectedEventArgs(Guid id, UserDto user) 
            : base(id)
        {
            User = user;
        }
    }
}
