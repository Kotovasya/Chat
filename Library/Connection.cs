using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Connection
    {
        public Guid Id { get; set; }
        public bool IsTemporary { get; set; }
        public OperationContext Context { get; set; }

        public Connection(Guid id, OperationContext context)
        {
            Id = id;
            IsTemporary = false;
            Context = context;
        }
        
        public Connection()
        {
            Id = Guid.NewGuid();
            IsTemporary = true;
            Context = OperationContext.Current;
        }
    }
}
