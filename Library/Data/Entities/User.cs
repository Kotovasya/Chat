using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    /// <summary>
    /// Сущность базы данных, хранящая информацию о пользователях
    /// </summary>
    public class User : IDto<UserDto>
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        /// Инициализирует нового пользователя
        /// </summary>
        public User()
        {
            Id = Guid.NewGuid();
            Messages = new List<Message>();
        }

        /// <summary>
        /// Инициализирует нового пользователя с заданным логином (именем) и паролем
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        public User(string login, string password)
            : this()
        {
            Login = login;
            Password = password;
        }

        public UserDto ToDto()
        {
            return new UserDto(Id, Login);
        }
    }
}
