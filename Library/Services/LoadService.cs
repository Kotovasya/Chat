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
                var orderedMessages = context.Dialogs.Find(request.DialogId).Messages.OrderByDescending(m => m.Id);
                var messages = request.LastMessageId == null ? 
                orderedMessages.Take(50) : 
                orderedMessages.SkipWhile(m => m.Id > request.LastMessageId).Take(50);
                return new LoadMessagesResponse() { Result = Contracts.Result.Succesfully, Messages = messages.Select(m => m.ToDto()) };
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
                var orderedDialogs = context.Users.Find(request.Id).Dialogs.OrderBy(d => d.Messages.Last().Date);
                var dialogs = request.LastDialogId == null ?
                orderedDialogs.Take(50) :
                orderedDialogs.SkipWhile(d => d.Id != request.LastDialogId).Take(50);
                return new LoadDialogsResponse() { Result = Contracts.Result.Succesfully, Dialgos = dialogs.Select(d => d.ToDto()) };
            });
        }
    }
}
