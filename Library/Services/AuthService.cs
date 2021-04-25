using Library.Data.Entities;
using Library.Contracts.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        /// <summary>
        /// Вызывается после успешной авторизации пользователя, удаляет старое соединение и возвращает результат успешной авторизации
        /// </summary>
        /// <param name="oldId">Старый ID клиента</param>
        /// <param name="user">Экземпляр авторизованного пользователя</param>
        /// <returns></returns>
        private AuthResponse CreateResponse(Guid oldId, User user)
        {
            connections.Add(user.Id, new Connection(user.Id, connections[oldId].Context));
            connections.Remove(oldId);
            SendBroadcastEvent(new UserConnectedEventArgs(user.Id, user.ToDto()));
            return new AuthResponse() { Result = Contracts.Result.Succesfully, Id = user.Id };
        }

        /// <summary>
        /// Авторизовывает клиента, как пользователя и возвращает результат авторизации
        /// </summary>
        /// <param name="request">Запрос на атворизацию</param>
        /// <returns>Ответ на авторизацию</returns>
        public AuthResponse Authorization(AuthRequest request)
        {
            return Preform(() => 
            {
                var user = context.Users.SingleOrDefault(u => u.Login.ToLower() == request.Login.ToLower());
                if (user == null)
                    return new AuthResponse() { Result = Contracts.Result.WrongLogin };
                if (user.Password != request.Password)
                    return new AuthResponse() { Result = Contracts.Result.WrongPassword };
                else
                    return CreateResponse(request.Id, user);
            });
        }

        /// <summary>
        /// Регистрирует клиента как пользователя в базе данных и возвращает результат регистрации
        /// </summary>
        /// <param name="request">Запрос на регистрацию</param>
        /// <returns>Ответ на регистрацию</returns>
        public AuthResponse Registration(AuthRequest request)
        {
            return Preform(() => 
            {
                if (!CheckValidName(request.Login))
                    return new AuthResponse() { Result = Contracts.Result.InvalidName };

                if (!CheckValidPassword(request.Password))
                    return new AuthResponse() { Result = Contracts.Result.InvalidPassword };

                if (context.Users.Any(u => u.Login.ToLower() == request.Login.ToLower()))
                    return new AuthResponse() { Result = Contracts.Result.AlreadyRegister };

                User user = context.Users.Add(new User(request.Login, request.Password));
                context.SaveChanges();
                return CreateResponse(request.Id, user);
            });
        }
    }
}
