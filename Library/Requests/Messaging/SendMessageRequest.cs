using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Requests.Messaging
{
    [DataContract]
    public class SendMessageRequest : Request
    {
        [DataMember]
        public string Text { get; set; }
    }
}
