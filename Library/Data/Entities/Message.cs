using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Library.Data.Entities
{
    /// <summary>
    /// Сущность базы данных, хранящая информацию о сообщении
    /// </summary>
    public partial class Message : IDto<MessageDto>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string Text { get; set; }

        public Guid Author_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int Dialog_Id { get; set; }

        public virtual Dialog Dialog { get; set; }

        public virtual User Author { get; set; }

        public MessageDto ToDto()
        {
            return new MessageDto(Id, Author.ToDto(), Text, Date, Dialog_Id);
        }
    }
}
