using InventoryLib;
using InventoryData.Repositories;

using var context = new AppDbContext();
// Ensure DB exists
await context.Database.EnsureCreatedAsync();

IProductRepository repo = new ProductRepository(context);

// CREATE
Product newProduct = new Product
        {
            Name = "Laptop2",
            Description = "Lenovo2",
            Price = 56000,
            Quantity = 2
        };
await repo.Add(newProduct);
await context.SaveChangesAsync();
Console.WriteLine("Product inserted.");

List<Product> products =  await repo.GetAll();
Console.WriteLine("\nAll Products:");
        foreach (var p in products) {
            Console.WriteLine($"{p.Id}: {p.Name}, {p.Price}");
        }
// Get By Id
Product product = await repo.GetById(3);
    if (product != null)
        {
            Console.WriteLine($"Found: {product.Name} - {product.Price}");
        }

// UPDATE
    // if (product != null)
    //     {
    //         product.Price = 899.99M;
    //         await repo.Update(product);
    //         Console.WriteLine("Product updated.");
    //     }

// DELETE
    // if (product != null)
    //     {
    //         await repo.Delete(product.Id);
    //         Console.WriteLine("Product deleted.");
    //     }