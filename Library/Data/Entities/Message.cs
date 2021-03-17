using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    /// <summary>
    /// Сущность базы данных, хранящая информацию о сообщениях
    /// </summary>
    public class Message : IDto<MessageDto>
    {
        public long Id { get; set; }
        public string Text { get; set; }

        public Guid? UserId { get; set; }
        public virtual User User { get; set; }

        public MessageDto ToDto()
        {
            return new MessageDto(Id, User.ToDto(), Text);
        }
    }
}
