using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_09.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test1()
        {
            ViewBag.str = "Hello World";
            return View();
        }
        public ActionResult Test2()
        {
            return View();
        }
        public string Test3()
        {
            return "Hello World";
        }
    }
}