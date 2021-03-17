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
            Message message = new Message(args.Message);
            if (!Model.Users.ContainsKey(args.Id))
                Model.Users.Add(args.Id, new User(args.Id, args.Message.Author.Name, false));

            message.Author = Model.Users[args.Id];
            Model.Messages.Add(args.Message.Id, message);
        }

        public void OnUserConnected(UserConnectedEventArgs args)
        {
            if (Model.Users.ContainsKey(args.Id))
                Model.Users[args.Id].Online = true;
            else
                Model.Users.Add(args.Id, new User(args.User));
        }

        public void OnUserDiconnected(ServerEventArgs args)
        {
            Model.Users?.Remove(args.Id);
        }
    }
}
