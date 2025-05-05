using Microsoft.EntityFrameworkCore;
using InventoryLib;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = "server=localhost;user=root;database=products;password=manager";
        optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
    }
}
