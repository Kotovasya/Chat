using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Library.Data.Entities
{
    /// <summary>
    /// �������� ���� ������, �������� ���������� � ������������
    /// </summary>
    public partial class User : IDto<UserDto>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Id = Guid.NewGuid();
            Dialogs = new HashSet<Dialog>();
            Messages = new HashSet<Message>();
            OwnedDialogs = new HashSet<Dialog>();
        }


        /// <summary>
        /// �������������� ������ ������������ � �������� ������� (������) � �������
        /// </summary>
        /// <param name="login">����� ������������</param>
        /// <param name="password">������ ������������</param>
        public User(string login, string password)
            : this()
        {
            Login = login;
            Password = password;
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dialog> Dialogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dialog> OwnedDialogs { get; set; }

        public UserDto ToDto()
        {
            return new UserDto(Id, Login);
        }
    }
}
