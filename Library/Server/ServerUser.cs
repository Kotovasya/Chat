using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Server
{
    public class ServerUser
    {
        public ConnectionId Id { get; set; }
        public OperationContext Context { get; set; }

        public ServerUser(ConnectionId id, OperationContext context)
        {
            Id = id;
            Context = context;
        }

        public ServerUser(Guid id, OperationContext context)
            : this(new ConnectionId(id, true), context)
        { }
    }
}
