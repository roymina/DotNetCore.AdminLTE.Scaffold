using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.AdminLTE.Scaffold.Models;
using DotNetCore.AdminLTE.Scaffold.Models.Configs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotNetCore.AdminLTE.Scaffold.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        public HomeController(IOptions<AppSettings> appSettings) {
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {   
              return View(_appSettings);
        }

        
    }
}