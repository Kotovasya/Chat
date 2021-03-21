using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Dialog
{
    [DataContract]
    public class AddUserToDialogRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public Guid AddedId { get; set; }
    }
}
