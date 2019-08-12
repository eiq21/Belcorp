using Belcorp.Data.Configurations;
using Belcorp.Model;
using Microsoft.EntityFrameworkCore;

namespace Belcorp.Data
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }


        public SalesDbContext(DbContextOptions options)
            :base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
