using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogConsoleApp
{
    class ProductService
    {
        ProductRepo productRepo = new ProductRepo();
        public void Add(Product product)
        {
            productRepo.Add(product);
        }
        public Product UpdateProduct(int id, Product product)
        {
            Product updateProduct = productRepo.UpdateProduct(id, product);
            return updateProduct;
        }
        public void Delete(int id)
        {
            productRepo.Delete(id);
        }
        public void Display()
        {
            productRepo.Display();
        }
        public double GetTotalPrice(int id)
        {
            double totalPrice = productRepo.GetTotalPrice(id);
            return totalPrice;
        }
        public double GetDiscountedPrice(int id, int discount)
        {
            double discounterPrice = productRepo.GetDiscountedPrice(id, discount);
            return discounterPrice;
        }
    }
}
