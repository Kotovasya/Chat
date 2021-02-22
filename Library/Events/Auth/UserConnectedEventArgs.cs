using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Events.Auth
{
    [DataContract]
    public class UserConnectedEventArgs : ServerEventArgs
    {
        [DataMember]
        public string Login { get; set; }

        public UserConnectedEventArgs(Guid id, string login) 
            : base(id)
        {
            Login = login;
        }
    }
}
