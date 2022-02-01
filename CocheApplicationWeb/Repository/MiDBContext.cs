using CocheApplicationWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CocheApplicationWeb.Repository
{
    public class MiDBContext: DbContext
    {
        private IConfiguration configuration;
        public MiDBContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(configuration.GetConnectionString("conexion"));
        }

        public DbSet<Rueda> Ruedas { get; set; }

        public DbSet<Coche> Coches { get; set; }
    }
}
