using System.Collections.Generic;
using System;
using System.Linq;
using ProductsWebAPI.Models;
using ProductsWebAPI.Contexts;

namespace ProductsWebAPI.Repositories
{
    public class ProductManager : IProductManager
    {
        public bool Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
            return true;
        }

        public List<Product> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var products = from p in context.Products select p;
             return products.ToList<Product>();
            }
        }

        public Product GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var product = context.Products.Find(id);
             return product;
            }
        }

        public bool Insert(Product product)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Add(product);
                context.SaveChanges(); 
            }
            return true;
        }

        public bool Update(Product product)
        {
            using(var context = new CollectionContext())
            {
                var theProduct = context.Products.Find(product.Id);
                theProduct.Name =product.Name;
                theProduct.Quantity=product.Quantity;
                theProduct.Description=product.Description;
                theProduct.Price=product.Price;
                context.SaveChanges();
            }
            return true;
        }
    }
}