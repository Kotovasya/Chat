using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    [DataContract]
    public class MessageRemovedEventArgs : ServerEventArgs
    {
        public MessageRemovedEventArgs(Guid id, int dialogId, long[] messagesIds)
            : base(id)
        {
            DialogId = dialogId;
            MessagesIds = messagesIds;
        }

        public MessageRemovedEventArgs(RemoveMessageRequest request)
            : this (request.Id, request.DialogId, request.MessagesIds)
        {

        }

        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public long[] MessagesIds { get; set; }
    }
}
