using Library.Contracts;
using Library.Contracts.User;
using System.Linq;

namespace Library.Services
{
    public partial class Service
    {
        /// <summary>
        /// Изменяет пароль пользователя и возвращает результат выполнения операции
        /// </summary>
        /// <param name="request">Запрос на изменение</param>
        /// <returns>Результат операции</returns>
        public Response ChangePassword(ChangePasswordRequest request)
        {
            return Preform(() =>
            {
                if (!CheckValidPassword(request.NewPassword))
                    return new Response() { Result = Result.InvalidPassword };

                var user = context.Users.Find(request.Id);
                if (user.Password != request.OldPassword)
                    return new Response() { Result = Result.WrongPassword };
                user.Password = request.NewPassword;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return new Response() { Result = Result.Succesfully };
            });
        }


        /// <summary>
        /// Изменяет имя пользователя и возвращает результат выполнения операции
        /// </summary>
        /// <param name="request">Запрос на изменение</param>
        /// <returns>Результат операции</returns>
        public Response ChangeUsername(ChangeUsernameRequest request)
        {
            return Preform(() =>
            {
                if (!CheckValidName(request.NewName))
                    return new Response() { Result = Result.InvalidName };

                if (context.Users.Any(u => u.Login == request.NewName))
                    return new Response() { Result = Result.AlreadyRegister };
                var user = context.Users.Find(request.Id);
                user.Login = request.NewName;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                SendBroadcastEvent(new UsernameChangedEventArgs(request.Id, request.NewName));
                return new Response() { Result = Result.Succesfully };
            });
        }
    }
}
