using Library.Data.Entities;
using Library.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            return Preform(() =>
            {
                User user = context.Users.Find(request.Id);
                context.Messages.Add(new Message() { Id = context.Messages.LongCount(), Text = request.Text, UserId = request.Id });
                SendBroadcastEvent(new MessageSendEventArgs(request.Id, string.Format("{0} said: {1}", user?.Login, request.Text)));
                return new SendMessageResponse() { Result = Contracts.Result.Succesfully };
            });
        }
    }
}
