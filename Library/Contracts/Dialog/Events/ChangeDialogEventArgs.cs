using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Dialog
{
    [DataContract]
    public class ChangeDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public ChangeDialogRequest ChangedInfo { get; set; }

        public ChangeDialogEventArgs(Guid id) : base(id)
        {
        }
    }
}
