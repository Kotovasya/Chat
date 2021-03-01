using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Auth
{
    [DataContract]
    public class AuthResponse : Response
    {
         [DataMember]
         public Guid Id { get; set; }
    }
}
