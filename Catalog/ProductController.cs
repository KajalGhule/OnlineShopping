using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogConsoleApp
{
    class ProductController
    {
        ProductService productService = new ProductService();
        public void Add(Product product) { 
            productService.Add(product);
        }
        public Product UpdateProduct(int id, Product product) {
            Product updatedProduct = productService.UpdateProduct(id, product);
            return updatedProduct;
        }
        public void Delete(int id) {
            productService.Delete(id);
        }
        public void Display()
        {
            productService.Display();
        }
        public double GetTotalPrice(int id)
        {
            double totalPrice = productService.GetTotalPrice(id);
            return totalPrice;
        }
        public double GetDiscountedPrice(int id, int discount)
        {
            double discounterPrice = productService.GetDiscountedPrice(id, discount);
            return discounterPrice;
        }
    }
}
