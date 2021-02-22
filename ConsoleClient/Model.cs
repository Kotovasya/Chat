using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    internal sealed class Model
    {
        public Guid Id { get; set; }
        public Dictionary<Guid, string> UsersOnline;

        public Model()
        {
            UsersOnline = new Dictionary<Guid, string>();
        }
    }
}
