using ConsoleClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Callbacks
{
    public partial class CallbackService
    {
        public void OnUserConnected(UserConnectedEventArgs args)
        {
            model.UsersOnline.Add(args.Id, args.Login);
        }
    }
}
