using Library.Contracts;
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
                var dialog = context.Dialogs.Find(request.DialogId);
                if (dialog.Messages.Count == 0 || dialog.Messages.First().Id == request.LastMessageId)
                    return new LoadMessagesResponse() { Result = Contracts.Result.AllLoad };

                var orderedMessages = dialog.Messages.OrderByDescending(m => m.Id);
                var messages = request.LastMessageId == null ? 
                orderedMessages.Take(50) : 
                orderedMessages.SkipWhile(m => m.Id > request.LastMessageId).Take(50);
                return new LoadMessagesResponse() { Result = Result.Succesfully, Messages = messages.Reverse().Select(m => m.ToDto()) };
            });
        }

        /// <summary>
        /// Запрашивает диалоги пользователя из базы данных и возвращает результат запроса
        /// </summary>
        /// <param name="request">Запрос на загрузку</param>
        /// <returns>Ответ на загрузку</returns>
        public LoadDialogsResponse LoadDialogs(LoadDialogsRequest request)
        {
            return Preform(() =>
            {
                var user = context.Users.Find(request.Id);
                return new LoadDialogsResponse() 
                { 
                    Result = Result.Succesfully, 
                    Dialogs = user.Dialogs.Select(d => d.ToDto()) 
                };
            });
        }

        public LoadDialogUsersResponse LoadDialogUsers(LoadDialogUsersRequest request)
        {
            return Preform(() =>
            {
                var user = context.Users.Find(request.Id);
                var dialog = context.Dialogs.Find(request.DialogId);
                if (!dialog.Users.Contains(user))
                    return new LoadDialogUsersResponse() { Result = Result.NotPremissions };

                return new LoadDialogUsersResponse()
                {
                    Result = Result.Succesfully,
                    Users = dialog.Users.Select(u => u.ToDto())
                };
            });
        }
    }
}
