using System;

namespace CatalogConsoleApp
{
    class ProductCatalog
    {
        public static int Menu()
        {
            int choose;
            Console.WriteLine("0.Exit......");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display All Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exist");
            choose = Convert.ToInt32(Console.ReadLine());
            return choose;
        }
        public static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            
            int choose;
            do
            {
                choose= Menu();
                switch(choose)
                {
                    case 0:
                        Console.WriteLine("Thank You Visit again !!!!!");
                        break;
                    case 1:
                        Product p = new Product();
                        p.Accept();
                        productController.Add(p);
                        break;
                    case 2:
                        productController.Display();
                        
                        break;
                    case 3:
                        Console.WriteLine("Enter Product Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p1 = new Product();
                        p1.Accept();
                        Product updatedProduct = productController.UpdateProduct(id, p1);
                        if (updatedProduct != null)
                        {
                            Console.WriteLine("Product Updated Successfullyyy!!!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Upss Product Not Founddd!!!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Id to Delete Product");
                        int i = Convert.ToInt32(Console.ReadLine());
                        productController.Delete(i);
                        break;
                    default:

                        break;
                }
            } while (choose != 0);
        }
    }
}