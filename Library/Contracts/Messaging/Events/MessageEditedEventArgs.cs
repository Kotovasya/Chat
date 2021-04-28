using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    [DataContract]
    public class MessageEditedEventArgs : ServerEventArgs
    {
        public MessageEditedEventArgs(Guid id, int dialogId, long messageId, string newText)
            : base(id)
        {
            DialogId = dialogId;
            MessageId = messageId;
            NewText = newText;
        }

        public MessageEditedEventArgs(EditMessageRequest request)
            : this(request.Id, request.DialogId, request.MessageId, request.NewText)
        {

        }

        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public long MessageId { get; set; }

        [DataMember]
        public string NewText { get; set; }
    }
}
