using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Core.DBContexts
{
    public class CollectionContext:DbContext{

    public DbSet<Payment> Payments {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=paymentdb; user=root; password=manager";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Payment>(entity => 
        {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.PaymentDate).IsRequired();
          entity.Property(e => e.Amount).IsRequired();
          entity.Property(e => e.OrderId).IsRequired();
          entity.Property(e => e.PaymentMode).IsRequired();
        });
    }
    }
}