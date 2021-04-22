using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Dialog
{
    [DataContract]
    public class CreateDialogResponse : Response
    {
        [DataMember]
        public DialogDto Dialog { get; set; }
    }
}
