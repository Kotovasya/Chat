using Library.Data.Entities;
using System.Data.Entity;

namespace Library.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("DBConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
