 
using Microsoft.EntityFrameworkCore;
using ApiProject.Model_s;

namespace ApiProject.DataAccess
{
    public class ProductContext : DbContext // inherit from dbcontext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) // generating a constructor
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; } // represent the database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between Order and Product
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany()
                .HasForeignKey(o => o.ProductId);
        }
    }
} 


