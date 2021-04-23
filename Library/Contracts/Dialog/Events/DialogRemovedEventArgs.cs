using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Dialog
{
    [DataContract]
    public class DialogRemovedEventArgs : ServerEventArgs
    {
        public DialogRemovedEventArgs(Guid id, int dialogId)
            : base(id)
        {
            DialogId = dialogId;
        }

        [DataMember]
        public int DialogId { get; set; }
    }
}
