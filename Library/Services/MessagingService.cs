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
        /// <summary>
        /// Отправляет сообщение, добавляет в базу данных и возвращает результат отправки
        /// </summary>
        /// <param name="request">Запрос на отправку сообщения</param>
        /// <returns>Результат отправки сообщения</returns>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            return Preform(() =>
            {
                var user = context.Users.Find(request.Id);
                var message = context.Messages.Add(new Message() { Id = context.Messages.LongCount(), Text = request.Text, UserId = request.Id });
                user.Messages.Add(message);
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return new SendMessageResponse() { Result = Contracts.Result.Succesfully, MessageId = message.Id };
            });
        }
    }
}
