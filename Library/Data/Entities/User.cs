using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class User : IDto<UserDto>
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            Messages = new List<Message>();
        }

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
