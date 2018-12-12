using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.AdminLTE.Scaffold.Models;
using DotNetCore.AdminLTE.Scaffold.Utility;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.AdminLTE.Scaffold.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //检查用户信息 
                if (loginModel.Username == "aaa" && loginModel.Password =="aaa")
                {
                    //记录Session
                    HttpContext.Session.Set("CurrentUser", Helper.Object2Bytes(loginModel));
                    //跳转到系统首页
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorInfo = "用户名或密码错误";
                return View();
            }
            ViewBag.ErrorInfo = ModelState.Values.First().Errors[0].ErrorMessage;
            return View(loginModel);
        }
    }
}