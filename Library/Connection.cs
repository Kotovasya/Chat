using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс, хранящий информацию о подключенном клиенте к сервису
    /// </summary>
    public class Connection
    {
        public Guid Id { get; set; }
        public bool IsTemporary { get; set; }
        public OperationContext Context { get; set; }

        /// <summary>
        /// Инициализирует подключение к сервису авторизованного клиента
        /// </summary>
        /// <param name="id">ID пользователя</param>
        /// <param name="context">Контекст обратного вызова клиента</param>
        public Connection(Guid id, OperationContext context)
        {
            Id = id;
            IsTemporary = false;
            Context = context;
        }
        
        /// <summary>
        /// Инициализирует экземпляр временного подключения клиента к сервису
        /// </summary>
        public Connection()
        {
            Id = Guid.NewGuid();
            IsTemporary = true;
            Context = OperationContext.Current;
        }
    }
}
