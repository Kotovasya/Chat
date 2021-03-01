using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    [DataContract]
    public class MessageSendEventArgs : ServerEventArgs
    {
        [DataMember]
        public string Text { get; set; }

        public MessageSendEventArgs(Guid id, string text) 
            : base(id)
        {
            Text = text;
        }
    }
}
