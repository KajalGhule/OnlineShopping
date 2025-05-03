using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerWebApp.Models;

namespace TransflowerWebApp.Controllers
{
    //is a kind of class 
    // for defining action methods for each incomming HTTP Request
    // http://localhost:5000/Products/index
    // http://localhost:5000/Products/details
    // http://localhost:5000/Products/insert
    // http://localhost:5000/Products/update

    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        //action Method: Handles HTTP request by providing logic
        // and sends view to Razor view engine 
        
        public IActionResult Index()   /// index.cshtml
        {
            List<string> products=new List<string>();
            products.Add("Lotus");
            products.Add("Carnation");
            products.Add("Marigold");
            products.Add("Jasmine");
            products.Add("Rose");
            products.Add("Gerbera");
            products.Add("Lily");

            ViewData["allProducts"]=products;
          
            /*List<Product> allProducts= Catalog.ProductManager.GetAllProducts();
            this.ViewData["products"]=allProducts;
            */

            return View();
        }
        public IActionResult Details(int id)
        {

           /* Product Product = Catalog.ProductManager.Get(id);
            ViewData["details"]=Product;
            */
            
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}