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




        //https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2


        [Route("cars/{year:min(1922)}")]                                                      // http://localhost:54871/cars/9 not work!  http://localhost:54871/cars/9999 will work!
        //[Route("vehicle/{make:minlength(5)}/{year:regex(\\d{4})}")]                         // http://localhost:54871/vehicle/chev/2019  Not work! chev is 4 char http://localhost:54871/vehicle/honda/2019 works!
        //[Route("vehicle/{make}/{year:regex(\\d{4})}")]                                      // http://localhost:54871/vehicle/honda/2019
        //[Route("foo/foo/foo/{make}/{year}")]                                                // http://localhost:54871/foo/foo/foo/toy/1231
        public ActionResult Make(string make, int year)
        {
            return Content($"This is the 'Make' action. You passed two parameters, {make} and {year}.");
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

        
        // Demonstrate Action Parameters (how parameters get to the code)
        public ActionResult Edit(int id)
        {
            return Content($"id={id}");      //   /vehicle/edit/1   OR  /vehicle/edit?id=1
        }


        //  Demo handling multiple parameters
        //  /vehicle/default?pageIndex=132&sortBy=OtherDate
        public ActionResult Default(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }






        // Demonstrate some other things you can return from these actions.
        
        public ContentResult Content()
        {
            return Content("this is some content");                     // return text to the browser  
        }



        public EmptyResult Empty()
        {
            return new EmptyResult();                                   // will return blank to the browser
        }



        public ActionResult Google()
        {
            return new RedirectResult(@"https://www.google.com");       // redirect to google
        }


        public FileResult File()
        {
            return File(@"c:\windows\win.ini","text/HTML");             // will return the text from this file 
        }


        public HttpNotFoundResult NotFound()
        {
            return HttpNotFound();                                      // return 404 error
        }
        


        public ActionResult ToAction()
        {
            return RedirectToAction("About", "Home", new { pg = 1, x = "s"});     // will go to another page
        }


      

    }
}