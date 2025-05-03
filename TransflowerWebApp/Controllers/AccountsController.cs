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

    public class AccountsController : Controller
    {

         private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
            
        }
        public IActionResult Register()
        {
            return View();
           
        }

        public IActionResult ForgotPassword( )
        {
            return View();
           
        }

    }








}
