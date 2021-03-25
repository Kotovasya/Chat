using Library.Contracts;
using Library.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        public Response ChangePassword(ChangePasswordRequest request)
        {
            return Preform(() =>
            {
                var user = context.Users.Find(request.Id);
                if (user.Password != request.OldPassword)
                    return new Response() { Result = Result.WrongPassword };
                user.Password = request.NewPassword;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return new Response() { Result = Result.Succesfully };
            });
        }

        public Response ChangeUsername(ChangeUsernameRequest request)
        {
            return Preform(() =>
            {
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
