using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.DTO
{
    [DataContract]
    public class DialogDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Guid OwnerId { get; set; }

        [DataMember]
        public IEnumerable<MessageDto> Messages { get; set; }

        [DataMember]    
        public IEnumerable<UserDto> Users { get; set; }

        public DialogDto(Data.Entities.Dialog dialog)
        {
            Id = dialog.Id;
            Name = dialog.Name;
            OwnerId = dialog.Owner_Id;
            Users = dialog.Users.Select(u => u.ToDto());
            Messages = dialog.Messages.Reverse().Take(50).Reverse().Select(m => m.ToDto());
        }
    }
}
