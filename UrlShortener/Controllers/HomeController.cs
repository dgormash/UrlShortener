using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class HomeController : Controller
    {
        private readonly User _user;
        public HomeController()
        {
            _user = new User();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(_user);
        }
    }
}