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


        [Route("vehicle/{make}/{year:regex(\\d{4})}")]
        [Route("foo/foo/foo/{make}/{year}")]
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