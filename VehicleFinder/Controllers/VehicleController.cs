using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleFinder.Models;

namespace VehicleFinder.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Special()
        {
            var car = new Vehicle()
            { VehicleId = 1001,
                VehicleMake = "Toyota",
                VehicleModel = "Sienna",
                VehicleYear = 2006
            };
            return View(car);
        }


    }
}