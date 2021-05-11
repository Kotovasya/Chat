using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.DTO
{
    /// <summary>
    /// Класс, хранящий информацию о пользователе и служащий для передачи этой информации клиентам сервиса
    /// </summary>
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsOnline { get; set; }
        [DataMember]
        public DateTime LastActivity { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса данных о пользователе, служащего для передачи данных пользователя клиенту сервиса
        /// </summary>
        /// <param name="id">ID пользователя</param>
        /// <param name="name">Логин (имя) пользователя</param>
        public UserDto(Data.Entities.User user)
        {
            Id = user.Id;
            Name = user.Login;
            IsOnline = false;
            LastActivity = user.LastActivity;
        }
    }
}
