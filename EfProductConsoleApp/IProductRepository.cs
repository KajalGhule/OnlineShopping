using InventoryLib;

namespace InventoryData.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task<bool> Add(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(int id);
    }
}
