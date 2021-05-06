using Library.Data;
using Library.Contracts;
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
    /// <summary>
    /// Сервис, принимающий запросы и возвращающий ответы клиентам этого сервиса
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
    public partial class Service : IService
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private readonly Data.DatabaseContext context;
        /// <summary>
        /// Словарь, хранящий созданные и активные подключения в данный момент
        /// </summary>
        private readonly Dictionary<Guid, Connection> connections;


        public Service()
        {
            context = new Data.DatabaseContext();
            connections = new Dictionary<Guid, Connection>();
        }

        /// <summary>
        /// Создает подключение нового временного клиента сервиса
        /// </summary>
        /// <returns>ID клиента</returns>
        public Guid Connect()
        {
            Connection connection = new Connection();
            try
            {
                connections.Add(connection.Id, connection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return connection.Id;
        }

        /// <summary>
        /// Вызывается для обозначения, что клиент отключился от сервера
        /// </summary>
        /// <param name="id">ID отключившегося клиента</param>
        public void Disconnect(Guid id)
        {
            connections.Remove(id);
        }

        /// <summary>
        /// Вызывается для выхода пользователя с аккаунта
        /// </summary>
        /// <param name="id">ID пользователя</param>
        /// <returns>ID нового подключения</returns>
        public Guid LogOut(Guid id)
        {
            Connection connection = new Connection(Guid.NewGuid(), connections[id].Context, true);
            connections.Add(connection.Id, connection);
            connections.Remove(id);
            return connection.Id;
        }

        /// <summary>
        /// Выполняет операцию, передеваемую в метод и, в случае неудачного ее выполнения, возвращает ошибку операции
        /// </summary>
        /// <typeparam name="T">Класс ответа</typeparam>
        /// <param name="method">Операция, которую необходимо выполнить</param>
        /// <returns>Возвращает результат выполнения операции клиенту</returns>
        private T Preform<T>(Func<T> method)
            where T : Response, new()
        {
            try
            {
                return method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new T() { Result = Result.ServerException };
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
                .Where(k => isTemporary || !k.Value.IsTemporary)
                .Select(k => k.Key)
                , args);
        }

        /// <summary>
        /// Проверяет, является ли имя действительным
        /// </summary>
        /// <param name="name">Строка с именем для проверки</param>
        /// <returns></returns>
        private bool CheckValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length > 2 && name.Length <= 30;
        }

        /// <summary>
        /// Проверяет, является ли пароль действительным
        /// </summary>
        /// <param name="password">Строка с паролем для проверки</param>
        /// <returns></returns>
        private bool CheckValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length > 3;
        }
    }
}
