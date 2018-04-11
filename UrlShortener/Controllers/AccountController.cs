using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(User user)
        {
            //1. Проверить, есть ли такой пользователь в базе данных
            //2. Если есть, то перенаправить на главную страницу (UrlShortenerService)
            //3. Если нет, то выдать сообщение об ошибке и предложить зарегистрировать пользователя
            //4. Назначить токен
            var result = true;
            if (result)
            {
                //Логика проверки валидности пользователя.
                return RedirectToAction("Index", "MainActivity");
            }
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