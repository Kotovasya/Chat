using Library.Data;
using Library.Events;
using Library.Server;
using Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service : IService
    {
        private readonly DatabaseContext context;
        private readonly Dictionary<Guid, ServerUser> connections;


        public Service()
        {
            context = new DatabaseContext();
            connections = new Dictionary<Guid, ServerUser>();
        }

        public Guid Connect()
        {
            ConnectionId connection = new ConnectionId(true);
            try
            {
                connections.Add(connection.Id, new ServerUser(connection, OperationContext.Current));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return connection.Id;
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
                Console.WriteLine(ex);
                return new T() { Result = Responses.Result.ServerException };
                throw;
            }
        }

        /// <summary>
        /// Отправить событие заданному клиенту сервиса
        /// </summary>
        /// <typeparam name="T">Интерфейс обратного вызова</typeparam>
        /// <param name="id">ID клиента, которому будет отправлено событие</param>
        /// <param name="args">Аргументы события, передаваемые в один из методов интерфейса</param>
        private void SendEvent(Guid id, ServerEventArgs args)
        {
            if (args.Id != id && connections.ContainsKey(id))
            {
                var service = connections[id].Context.GetCallbackChannel<IServiceCallback>();
                foreach (var methodInfo in service.GetType().GetMethods())
                    if (methodInfo.GetParameters()[0].ParameterType == args.GetType())
                    {
                        methodInfo.Invoke(service, new[] { args });
                        return;
                    }              
            }
        }

        /// <summary>
        /// Отправить событие заданным клиентам сервиса
        /// </summary>
        /// <typeparam name="T">Интерфейс обратного вызова</typeparam>
        /// <param name="ids">ID клиентов, которым будет отправлено событие</param>
        /// <param name="args">Аргументы события, передаваемые в один из методов интерфейса</param>
        private void SendEvent(IEnumerable<Guid> ids, ServerEventArgs args)
        {
            foreach (var id in ids)
                SendEvent(id, args);
        }

        /// <summary>
        /// Отправить событие всем клиентам сервиса
        /// </summary>
        /// <typeparam name="T">Интерфейс обратного вызова</typeparam>
        /// <param name="args">Аргументы события, передаваемые в один из методов интерфейса</param>
        /// <param name="isTemporary">Флаг, определяющий вызывать ли метод для неавторизованных клиентов</param>
        private void SendBroadcastEvent(ServerEventArgs args, bool isTemporary = false)
        {
            SendEvent(connections
                .Where(k => isTemporary || !k.Value.Id.IsTemporary)
                .Select(k => k.Key)
                , args);
        }
    }
}
