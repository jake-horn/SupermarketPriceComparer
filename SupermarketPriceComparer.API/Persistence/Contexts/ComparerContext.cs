using Microsoft.EntityFrameworkCore;
using SupermarketPriceComparer.API.Models;

namespace SupermarketPriceComparer.API.Persistence.Contexts
{
    public class ComparerContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Retailer> Retailers { get; set; }

        public ComparerContext(DbContextOptions<ComparerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Retailer>().ToTable("Retailer");
        }
    }
}
