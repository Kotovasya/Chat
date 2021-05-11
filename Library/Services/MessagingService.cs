using Library.Data.Entities;
using Library.Contracts.Messaging;
using System;
using System.Linq;
using Library.Contracts;

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
                if (string.IsNullOrWhiteSpace(request.Text) || request.Text == string.Empty)
                    return new SendMessageResponse() { Result = Result.EmptyMessage };

                var user = context.Users.Find(request.Id);
                var dialog = context.Dialogs.Find(request.DialogId);
                if (!dialog.Users.Contains(user))
                    return new SendMessageResponse() { Result = Result.UserNotInDialog };

                var message = context.Messages.Add(new Message()
                {
                    Id = context.Messages.LongCount(),
                    Dialog_Id = request.DialogId,
                    Text = request.Text,
                    Author_Id = request.Id,
                    Date = DateTime.UtcNow
                });
                context.SaveChanges();
                SendEvent(dialog.Users.Select(u => u.Id), new MessageSendEventArgs(request.Id, message.ToDto()));
                return new SendMessageResponse() { Result = Result.Succesfully, MessageId = message.Id };
            });
        }

        /// <summary>
        /// Редактирует сообщение, изменяя его в базе данных и возвращает результат редактирования
        /// </summary>
        /// <param name="request">Запрос на редактирование</param>
        /// <returns>Результат редактирования</returns>
        public Response EditMessage(EditMessageRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.NewText) || request.NewText == string.Empty)
                return new Response() { Result = Result.EmptyMessage };

            var user = context.Users.Find(request.Id);
            var dialog = context.Dialogs.Find(request.DialogId);
            if (!dialog.Users.Contains(user))
                return new Response() { Result = Result.UserNotInDialog };

            var message = context.Messages.Find(request.MessageId);
            if (message.Author.Id != request.Id)
                return new Response() { Result = Result.NotPremissions };

            message.Text = request.NewText;
            context.Entry(message).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            SendEvent(dialog.Users.Select(u => u.Id), new MessageEditedEventArgs(request));
            return new Response() { Result = Result.Succesfully };
        }

        /// <summary>
        /// Удаляет сообщение из базы данных и возвращает результат удаления
        /// </summary>
        /// <param name="request">Запрос на удаление</param>
        /// <returns>Результат удаления</returns>
        public Response RemoveMessage(RemoveMessageRequest request)
        {
            var user = context.Users.Find(request.Id);
            var dialog = context.Dialogs.Find(request.DialogId);
            if (!dialog.Users.Contains(user))
                return new Response() { Result = Result.UserNotInDialog };

            foreach (var id in request.MessagesIds)
            {
                var message = context.Messages.Find(id);
                if (message.Author.Id == request.Id)
                    context.Messages.Remove(message);
            }

            SendEvent(dialog.Users.Select(u => u.Id), new MessageRemovedEventArgs(request));
            return new Response() { Result = Result.Succesfully };
        }
    }
}
