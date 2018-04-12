using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;
using UrlShortener.SQLiteWork;

namespace UrlShortener.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(User user)
        {

            //4. Назначить токен
            var sqlite = new SqliteWorker();
            var result = sqlite.FindUserByCredentials(user.UserName, user.UserPassword);
            if (result)
            {
                return RedirectToAction("Index", "MainActivity");
            }
            user.LoginErrorMessage = "Неверный логин или пароль";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View("NewUser");
        }

        [HttpPost]
        public ActionResult Register(User user)
        {

            return View("NewUser");
        }
    }
}