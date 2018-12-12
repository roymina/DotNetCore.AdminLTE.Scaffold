using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.AdminLTE.Scaffold.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotNetCore.AdminLTE.Scaffold.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<Menu> _appConfiguration;
        public HomeController(IOptions<Menu> appConfiguration) {
            _appConfiguration = appConfiguration;
        }

        public IActionResult Index()
        {
           
              return View();
        }

        
    }
}