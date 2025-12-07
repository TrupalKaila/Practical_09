using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_Test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Test1()
        {
            ViewBag.str = "Hello World";
            return View();
        }
    }
}