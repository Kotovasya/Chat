using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Responses.Auth
{
    [DataContract]
    public class RegistrationResponse : Response
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}
