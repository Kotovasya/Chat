using Library.Contracts.Load;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        public LoadMessagesResponse LoadMessages(LoadMessagesRequest request)
        {
            return Preform(() =>
            {
                var messages = context.Messages.Reverse()
                    .SkipWhile((m, i) => m.Id > request.LastMessageId && i != 0)
                    .Take(50)
                    .Select(m => m.ToDto())
                    .ToList();
                return new LoadMessagesResponse() { Result = Contracts.Result.Succesfully, Messages = messages };
            });
        }
    }
}
