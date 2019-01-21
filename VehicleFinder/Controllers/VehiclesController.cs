using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleFinder.Models;

namespace VehicleFinder.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Vehicles
        public ActionResult Index()
        {
            return View(GetVehicles());
        }





        private List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>()
            {
                new Vehicle()
                {
                    VehicleId = 1001,
                    VehicleMake = "Toyota",
                    VehicleModel = "Sienna",
                    VehicleYear = 2006
                },
                new Vehicle()
                {
                    VehicleId = 1002,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic",
                    VehicleYear = 2005
                },
                new Vehicle()
                {
                    VehicleId = 1003,
                    VehicleMake = "American Motors",
                    VehicleModel = "Rebel",
                    VehicleYear = 1969
                }
            };
        }



    }
}