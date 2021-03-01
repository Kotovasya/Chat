using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }

        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
