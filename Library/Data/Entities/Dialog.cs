using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class Dialog : IDto<DialogDto>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        [ForeignKey("Owner")]
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public Dialog()
        {
            Users = new HashSet<User>();
            Messages = new HashSet<Message>();
        }

        public Dialog(int id, Guid ownerId, string name, string password)
            : this()
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            Password = password;
        }

        public DialogDto ToDto()
        {
            return new DialogDto(this);
        }
    }
}
