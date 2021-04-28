using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    [DataContract]
    public class EditMessageRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public long MessageId { get; set; }

        [DataMember]
        public string NewText { get; set; }
    }
}
