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
        /// <summary>
        /// Запрашивает сообщения из базы данных и возвращает результат запроса
        /// </summary>
        /// <param name="request">Запрос на загрузку</param>
        /// <returns>Ответ на загрузку</returns>
        public LoadMessagesResponse LoadMessages(LoadMessagesRequest request)
        {
            return Preform(() =>
            {
                var messages = request.LastMessageId == -1 ?
                    context.Messages.OrderByDescending(m => m.Id)
                    .Take(50)
                    .AsEnumerable()
                    .Select(m => m.ToDto())
                    : context.Messages.OrderByDescending(m => m.Id)
                    .SkipWhile((m, i) => m.Id > request.LastMessageId && i != 0)
                    .Take(50)
                    .AsEnumerable()
                    .Select(m => m.ToDto());
                return new LoadMessagesResponse() { Result = Contracts.Result.Succesfully, Messages = messages.ToList() };
            });
        }
    }
}
