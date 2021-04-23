using Library.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Library.Data
{
    /// <summary>
    /// Контекст базы данных, служащий для обращения к ее таблицам
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        /// <summary>
        /// Инициализирует контекст базы данных, строка подключения к которой находится в файле конфигурации
        /// </summary>
        public DatabaseContext()
            : base("DbConnection")
        {
        }

        public virtual DbSet<Dialog> Dialogs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dialog>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Dialog)
                .HasForeignKey(e => e.Dialog_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dialog>()
                .HasMany(e => e.Users)
                .WithMany(e => e.OwnedDialogs)
                .Map(m => m.ToTable("UsersDialogs"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.Dialogs)
                .WithRequired(e => e.Owner)
                .HasForeignKey(e => e.Owner_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Author)
                .HasForeignKey(e => e.Author_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
