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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class Service
    {
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
                {
                    connections[user.Id] = new Connection(user.Id, connections[request.Id].Context);
                    connections.Remove(request.Id);
                    SendBroadcastEvent(new UserConnectedEventArgs(user.Id, request.Login));
                    return new AuthResponse() { Result = Contracts.Result.Succesfully, Id = user.Id };
                }
            });
        }

        public RegistrationResponse Registration(RegistrationRequest request)
        {
            return Preform(() => 
            {
                if (context.Users.Any(u => u.Login.ToLower() == request.Login.ToLower()))
                    return new RegistrationResponse() { Result = Contracts.Result.AlreadyRegister };

                User user = context.Users.Add(new User(request.Login, request.Password));
                context.SaveChanges();

                connections[user.Id] = new Connection(user.Id, connections[request.Id].Context);
                connections.Remove(request.Id);
                SendBroadcastEvent(new UserConnectedEventArgs(user.Id, request.Login));
                return new RegistrationResponse() { Result = Contracts.Result.Succesfully, Id = user.Id };
            });
        }
    }
}
