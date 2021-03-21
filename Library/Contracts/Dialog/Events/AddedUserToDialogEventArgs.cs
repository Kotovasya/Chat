using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Dialog
{
    [DataContract]
    public class AddedUserToDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public UserDto AddedUser { get; set; }

        public AddedUserToDialogEventArgs(Guid id, int dialogId, UserDto addedUser) 
            : base(id)
        {
            DialogId = dialogId;
            AddedUser = addedUser;
        }
    }
}
