using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Library.Data.Entities
{
    /// <summary>
    /// Сущность базы данных, хранящая информацию о диалоге
    /// </summary>
    public partial class Dialog : IDto<DialogDto>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dialog()
        {
            Messages = new HashSet<Message>();
            Users = new HashSet<User>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public string Password { get; set; }

        public Guid Owner_Id { get; set; }

        public virtual User Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        public Dialog(int id, Guid ownerId, string name, string password)
            : this()
        {
            Id = id;
            Name = name;
            Owner_Id = ownerId;
            Password = password;
        }

        public DialogDto ToDto()
        {
            return new DialogDto(this);
        }
    }
}
