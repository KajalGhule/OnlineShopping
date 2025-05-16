using Microsoft.EntityFrameworkCore;
using ProductsWebAPI.Models;

namespace ProductsWebAPI.Contexts
{
    public class CollectionContext:DbContext{
    public DbSet<Product> Products {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=products; user=root; password=manager";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity => 
        {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.Name).IsRequired();
          entity.Property(e => e.Price).IsRequired();
          entity.Property(e => e.Quantity).IsRequired();
        });
    }
    }
}