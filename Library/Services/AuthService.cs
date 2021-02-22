using Library.Data.Entities;
using Library.Events.Auth;
using Library.Requests.Auth;
using Library.Responses.Auth;
using Library.Server;
using Library.Services;
using Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class Service : IAuthService
    {
        public Guid Connect()
        {
            ConnectionId connection = new ConnectionId(true);
            try
            {
                connections.Add(connection.Id, null);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);          
            }
            return connection.Id;
        }

        public AuthResponse Authorization(AuthRequest request)
        {
            return Preform(() => {
                var user = context.Users.SingleOrDefault(u => u.Login.ToLower() == request.Login.ToLower());
                if (user == null)
                    return new AuthResponse() { Result = Responses.Result.WrongLogin };
                if (user.Password != request.Password)
                    return new AuthResponse() { Result = Responses.Result.WrongPassword };
                else
                {
                    connections[user.Id] = new ServerUser(user.Id, connections[request.Id].Context);
                    connections[request.Id] = null;
                    SendEvent<IAuthCallback>("OnUserConnected", new UserConnectedEventArgs(user.Id, request.Login));
                    return new AuthResponse() { Result = Responses.Result.Succesfully, Id = user.Id };
                }
            });
        }

        public RegistrationResponse Registration(RegistrationRequest request)
        {
            return Preform(() => {
                if (context.Users.Any(u => u.Login.ToLower() == request.Login.ToLower()))
                    return new RegistrationResponse() { Result = Responses.Result.AlreadyRegister };

                User user = context.Users.Add(new User(request.Login, request.Password));
                context.SaveChanges();

                connections[user.Id] = new ServerUser(user.Id, connections[request.Id].Context);
                connections[request.Id] = null;
                SendEvent<IAuthCallback>("OnUserConnected", new UserConnectedEventArgs(user.Id, request.Login));
                return new RegistrationResponse() { Result = Responses.Result.Succesfully, Id = user.Id };
            });
        }
    }
}
