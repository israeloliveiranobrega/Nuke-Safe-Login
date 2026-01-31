using Microsoft.EntityFrameworkCore;
using Nuke_Safe_Login.Domain.Models;
using System.IO;

namespace SafePlaceLogin
{
    public class DBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<LoginAttempt> Users { get; set; }
        public DbSet<LoginAttempt> LoginAttempts { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
        }
    }
}
