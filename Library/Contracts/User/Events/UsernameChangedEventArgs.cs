using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.User
{
    [DataContract]
    public class UsernameChangedEventArgs : ServerEventArgs
    {
        [DataMember]
        public string NewName { get; set; }

        public UsernameChangedEventArgs(Guid id, string newName) 
            : base(id)
        {
            NewName = newName;
        }
    }
}
