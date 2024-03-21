using Microsoft.EntityFrameworkCore;
using SmallPizzaShop.Model;

namespace SmallPizzaShop.Data
{
    public class PizzaStoreContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public PizzaStoreContext(IConfiguration configuration)
        {
             Configuration = configuration;
        }


        public DbSet<PizzaSpecial> Specials { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("PizzaDB"));
        }
    }
}
