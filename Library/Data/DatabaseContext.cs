using Library.Data.Entities;
using System.Data.Entity;

namespace Library.Data
{
    /// <summary>
    /// Контекст базы данных, служащий для обращения к ее таблицам
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// Инициализирует контекст базы данных, строка подключения к которой находится в файле конфигурации
        /// </summary>
        public DatabaseContext()
            : base("DBConnection")
        {

        }

        /// <summary>
        /// Таблица пользователей
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Таблица сообщений
        /// </summary>
        public DbSet<Message> Messages { get; set; }
    }
}
