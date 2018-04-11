using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlShortener.Controllers
{
    public class MainActivityController : Controller
    {
        // GET: MainActiviti
        public ActionResult Index()
        {
            return View();
        }
    }
}