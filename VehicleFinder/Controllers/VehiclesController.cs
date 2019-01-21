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
		private ApplicationDbContext _context;   // need a db context to access the db

	    public VehiclesController()
	    {
			_context = new ApplicationDbContext();
	    }

		protected override void Dispose(bool disposing)     // for now do it this way
		{
			_context.Dispose();
		}



		// GET: Vehicles
		public ActionResult Index()
        {
            //return View(GetVehicles());
            return View(GetDbVehicles());
			//  return View(new List<Vehicle>());   // Switch with this commented out for rudimentary test wtih zero cars
		}



		public ActionResult Details(int id)
	    {
			// You MUST use the name "id" for the parameter. The route is configured to use that name.
		    
			//var ff = GetVehicles().SingleOrDefault(n => n.VehicleId == id);
		    //return Content($"The 'DETAILS' action. You passed: {id} 0 model ={ff.VehicleModel}");

		    //return View(GetVehicles().SingleOrDefault(n => n.VehicleId == id));
		    return View(GetDbVehicles().SingleOrDefault(n => n.VehicleId == id));
	    }



		private List<Vehicle> GetDbVehicles()
		{
			var vehicles = _context.Vehicles.ToList();
			return vehicles;
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
                    VehicleYear = 2006,
					ImageUrl = "https://www.cstatic-images.com/stock/900x600/239495.jpg"
				},
                new Vehicle()
                {
                    VehicleId = 1002,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic",
                    VehicleYear = 2005,
					ImageUrl = "https://proxy.duckduckgo.com/iu/?u=http%3A%2F%2Fcdn.pinthiscars.com%2Fimages%2Fhonda-civic-lx-2005-for-sale-wallpaper-2.jpg&f=1"
				},
                new Vehicle()
                {
                    VehicleId = 1003,
                    VehicleMake = "American Motors",
                    VehicleModel = "Rebel",
                    VehicleYear = 1969,
					ImageUrl = "https://proxy.duckduckgo.com/iu/?u=http%3A%2F%2Fx-img.autorevo.com%2F1969-amc-rebel-sst-phoenix-az-5645017%2F1193978-2-large.jpg&f=1"
				}
            };
        }



    }
}