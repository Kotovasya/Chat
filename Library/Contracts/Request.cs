using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    [DataContract]
    public abstract class Request
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}
