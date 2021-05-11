using Library.Contracts;
using Library.Contracts.DTO;
using Library.Contracts.Load;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var dialogs = context.Dialogs
                    .Where(d => d.Users.Any(u => u.Id == request.Id))
                    .ToArray()
                    .Select(d => d.ToDto());
                var response = new LoadDialogsResponse()
                {
                    Result = Result.Succesfully,
                    Dialogs = dialogs
                };
                return response;
            });
        }

        /// <summary>
        /// Запрашивает пользователей онлайн и возвращает результат запроса
        /// </summary>
        /// <param name="requestId">ID пользователя, отправляющего запрос</param>
        /// <returns>Ответ на загрузку</returns>
        public LoadOnlineUsersResponse LoadOnlineUsers(Guid requestId)
        {
            return Preform(() =>
            {
                var user = context.Users.Find(requestId);

                List<UserDto> users = new List<UserDto>();
                foreach(var id in connections.Keys)
                {
                    if (id != requestId)
                    {
                        var userDto = context.Users.Find(id).ToDto();
                        userDto.IsOnline = true;
                        users.Add(userDto);
                    }
                }

                return new LoadOnlineUsersResponse()
                {
                    Result = Result.Succesfully,
                    Users = users
                };
            });
        }
    }
}
