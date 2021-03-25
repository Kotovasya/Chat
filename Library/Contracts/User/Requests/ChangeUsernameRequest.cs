using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.User
{
    [DataContract]
    public class ChangeUsernameRequest : Request
    {
        [DataMember]
        public string NewName { get; set; }
    }
}
