using Client.ServiceReference;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class ClientCallbacks : IServiceCallback
    {
        public ClientModel Model { get; set; }

        public void OnMessageSend(MessageSendEventArgs args)
        {
            Model.Messages?.Add(args.Message.Id, new Message(args.Message));
        }

        public void OnUserConnected(UserConnectedEventArgs args)
        {
            Model.Users?.Add(args.Id, new User(args.User));
        }

        public void OnUserDiconnected(ServerEventArgs args)
        {
            Model.Users?.Remove(args.Id);
        }
    }
}
