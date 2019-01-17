using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VehicleFinder
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);   // these are routes for our application
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        //  Global ASX is one of the traditional files that has been in a split up net for a long time and it's
        //  a class that provides hooks for various events in the applications lifecycle.
        //  So let's expand this and open the C-sharp file.
        //  So when the application is started this method will be called.
        //  And here you can see we're registering a few things like the routes.
        //  So when the application started we tell the runtime.
        //  These are the routes for our application.






    }
}
