using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "More information about VehicleFinder.com.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here's how you can get a hold of us.";

            return View();
        }
    }
}