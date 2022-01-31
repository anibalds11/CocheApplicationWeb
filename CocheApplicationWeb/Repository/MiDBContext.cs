using CocheApplicationWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace CocheApplicationWeb.Repository
{
    public class MiDBContext: DbContext
    {
        public MiDBContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=BBDDCoches;Trusted_Connection=True;");
        }

        public DbSet<Rueda> Ruedas { get; set; }

        public DbSet<Coche> Coches { get; set; }
    }
}
