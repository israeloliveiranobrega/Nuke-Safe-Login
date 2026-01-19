using Microsoft.EntityFrameworkCore;
using System.IO;

namespace SafePlaceLogin
{
    public class DBContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
        }
    }
}
