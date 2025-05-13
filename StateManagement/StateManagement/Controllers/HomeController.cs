using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using StateManagement.Models;

namespace StateManagement.Controllers
{
    
    public class Cart
    {
        public List<String> Items = new List<String>();
        public Cart()
        {
            Items.Add("IPhone");
            Items.Add("Lenovo Laptop");
            Items.Add("Desktop");
        }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
             will store string, integer and complex object into
            session maintained inside distributed Cache 
            at server side
             */
            string SessionKeyName = "product";
            string SessionKeyAge = "age";
            HttpContext.Session.SetString(SessionKeyName, "Dell computer");
            HttpContext.Session.SetInt32(SessionKeyAge, 45);
            var CartObj = new Cart();
            var str = JsonSerializer.Serialize(CartObj);
            HttpContext.Session.SetString("cart", str);
            return View();
        }

        public IActionResult Privacy()
        {
            // get data from the server side session variable 
            // which is kept in distributed cache of server
            ViewBag.data = HttpContext.Session.GetString("product");
            var strCart = HttpContext.Session.GetString("cart");
            ViewData["cart"] = JsonSerializer.Deserialize<Cart>(strCart);
            return View();
        }
        public IActionResult QueryTest()
        {
            string name = string.Empty;
            string state = string.Empty;
            name = HttpContext.Request.Query["name"];
            state = HttpContext.Request.Query["state"];
            return Content("Query Test function invoked......" + name + " " + state);
        }
        public IActionResult Students()
        {
            List<String> data = new List<string>();
            data.Add("kajal");
            data.Add("omkar");
            var result = data.ToArray();
            return new JsonResult(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
