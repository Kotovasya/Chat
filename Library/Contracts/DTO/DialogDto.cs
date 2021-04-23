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
        public Dictionary<long, MessageDto> Messages { get; set; }

        [DataMember]
        public Dictionary<Guid, UserDto> Users { get; set; }

        public DialogDto()
        {
            Messages = new Dictionary<long, MessageDto>();
            Users = new Dictionary<Guid, UserDto>();
        }

        public DialogDto(Data.Entities.Dialog dialog)
            : this()
        {
            Id = dialog.Id;
            Name = dialog.Name;
            OwnerId = dialog.Owner_Id;
        }

        public DialogDto AddInfo(Data.Entities.Dialog dialog)
        {
            Users = dialog.Users.ToDictionary(u => u.Id, u => u.ToDto());
            Messages = dialog.Messages.Reverse().Take(50).ToDictionary(m => m.Id, m => m.ToDto());
            return this;
        }
    }
}
