using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Responses
{
    [DataContract]
    public abstract class Response
    {
        [DataMember]
        public Result Result { get; set; }
    }
}
