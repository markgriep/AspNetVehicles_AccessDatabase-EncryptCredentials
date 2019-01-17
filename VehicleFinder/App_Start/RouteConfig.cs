using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VehicleFinder
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Here are the routing rules 
            // Follows this pattern NameOfController, ActionName, ID to pass to the action
            // 
            // If it's https://www.foo.com/movies/edit/1  it will go to   MoviesController.Edit(1)
            

            // Defaults work this way: If url is missing parts...
            // If it's https://www.foo.com/               it will go to  HomeController.Index()    -- neither controller nor action is specified
            // If it's https://www.foo.com/movies         it will go to  MoviesController.Index()  -- controller is specified, but not action
            // If it's https://www.foo.com/movies/rand    it will go to  MoviesController.Rand()   -- all are specified

            // Notice ID is optional. Not all actions take in an ID.
        }
    }
}
