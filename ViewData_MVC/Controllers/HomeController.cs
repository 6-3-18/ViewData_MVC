using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_MVC.Controllers
{
    public class HomeController : Controller
    {
     /// <summary>
     /// ViewData["Message"]
     /// 2024/05/29
     /// </summary>
     /// <returns></returns>
        public ActionResult Index()
        {
            ViewData["Message"] = "Hello World!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}