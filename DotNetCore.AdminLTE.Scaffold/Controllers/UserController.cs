using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.AdminLTE.Scaffold.Models;
using DotNetCore.AdminLTE.Scaffold.Models.Configs;
using DotNetCore.AdminLTE.Scaffold.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotNetCore.AdminLTE.Scaffold.Controllers
{
    public class UserController : Controller
    {
        private readonly AppSettings _appSettings;
        public UserController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public IActionResult Login()
        {
            ViewBag.appName = _appSettings.ApplicationName;
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //check user status 
                if (loginModel.Username == "aaa" && loginModel.Password =="aaa")
                {
                    //login Session
                    HttpContext.Session.Set("CurrentUser", Helper.Object2Bytes(loginModel));
                    //redirect to home page if user verified
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorInfo = "username or password invalid";
                return View();
            }
            ViewBag.ErrorInfo = ModelState.Values.First().Errors[0].ErrorMessage;
            return View(loginModel);
        }
    }
}