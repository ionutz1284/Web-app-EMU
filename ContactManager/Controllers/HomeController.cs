using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to Eastern Michigan University website";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's keep in touch";

            return View();
        }
    }
}