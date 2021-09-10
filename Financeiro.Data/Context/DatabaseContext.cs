using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Financeiro.Data.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly string connectionString;
        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration) : base(options)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
