using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity<ProductCategory>(
                    j => j
                        .HasOne(pc => pc.Category)
                        .WithMany()
                        .HasForeignKey(pc => pc.categoryId),
                    j => j
                        .HasOne(pc => pc.Product)
                        .WithMany()
                        .HasForeignKey(pc => pc.productId),
                    j =>
                    {
                        j.HasKey(pc => new { pc.productId, pc.categoryId });
                        j.ToTable("ProductCategory");
                    }
                );
        }

        
    }
}