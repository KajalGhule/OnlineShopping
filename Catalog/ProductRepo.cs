using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogConsoleApp
{

    class ProductRepo
    {
        private List<Product> productsList = new List<Product>();

        public void Add(Product product)
        {
            productsList.Add(product);
        }
        public Product UpdateProduct(int id, Product product)
        {
            Product existingProduct = null;
            foreach (var item in productsList)
            {
                if (item.GetId() == id)
                {
                    existingProduct = item;
                    break;
                }
            }
            if (existingProduct != null)
            {
                productsList.Remove(existingProduct);
                existingProduct.SetTitle(product.GetTitle());
                existingProduct.SetDesc(product.Getdesc());
                existingProduct.SetQuantity(product.GetQuantity());
                existingProduct.SetUnitPrice(product.GetUnitPrice());
                productsList.Add(existingProduct);
                return existingProduct;
            }
            else
            {
                return null;
            }
        }
        public void Delete(int id)
        {
            foreach (var item in productsList)
            {
                if (item.GetId() == id)
                {
                    productsList.Remove(item);
                    break;
                }
            }
        }
        public void Display()
        {
            foreach (var item in productsList)
            {
                item.Display();
                Console.WriteLine("---------------------------------------");
            }
        }

    }
}
