using Microsoft.EntityFrameworkCore;
using InventoryLib;

namespace InventoryData.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext  _context;

        public ProductRepository(AppDbContext  context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAll() {
           List<Product> products = await _context.Products.ToListAsync();
           return products;
        } 

        public async Task<Product?> GetById(int id) {
            Product product = await _context.Products.FindAsync(id);
             return product;
        }

        public async Task<bool> Add(Product product)
        {
            _context.Products.Add(product);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(Product product)
        {
            var existing = await _context.Products.FindAsync(product.Id);
            if (existing == null) return false;

            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return false;
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
