using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public double GetTotalPrice(int id)
        {
            Product product = GetProduct(id);
            if (product != null)
            {
                double totalPrice = product.GetTotalPrice();   
                return totalPrice;
            }
            return 0;
        }
        public double GetDiscountedPrice(int id, int discount)
        {
            Product product = GetProduct(id);
            if (product != null)
            {
                double totalPrice = product.GetDiscountedPrice(discount);
                return totalPrice;
            }
            return 0;
        }

        public Product GetProduct(int id)
        {
            foreach (var item in productsList)
            {
                if (item.GetId() == id)
                { 
                    return item;
                }
            }
            return null;
        }

    }
}
