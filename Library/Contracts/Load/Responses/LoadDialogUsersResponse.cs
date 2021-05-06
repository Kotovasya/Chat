using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Load
{
    [DataContract]
    public class LoadDialogUsersResponse : Response
    {
        [DataMember]
        public IEnumerable<UserDto> Users { get; set; }
    }
}
