using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.AdminLTE.Scaffold.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}