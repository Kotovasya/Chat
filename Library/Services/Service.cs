using Library.Data;
using Library.Events;
using Library.Server;
using Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        private readonly DatabaseContext context;
        private readonly Dictionary<Guid, ServerUser> connections;


        public Service()
        {
            context = new DatabaseContext();
            connections = new Dictionary<Guid, ServerUser>();
        }

        private T Preform<T>(Func<T> method)
            where T : Responses.Response, new()
        {
            try
            {
                return method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new T() { Result = Responses.Result.ServerException };
                throw;
            }
        }

        private void SendEvent<T>(string methodName, ServerEventArgs args)
        {
            foreach(var connection in connections)
            {
                //if (connection.Key != args.Id)
                {
                    T service = connection.Value.Context.GetCallbackChannel<T>();
                    MethodInfo method = service.GetType().GetMethod(methodName);
                    method.Invoke(service, new[] { args });
                }
            }
        }
    }
}
