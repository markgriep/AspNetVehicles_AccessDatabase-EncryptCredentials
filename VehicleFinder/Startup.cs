using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleFinder.Startup))]
namespace VehicleFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

    //    We also have this startup.cs which is a new approach Microsoft is taking for a starting application.
    //    So in ASP.net Core 1.1 they have dropped global.asax and all that sort of logic is implemented
    //    in this startup class.
    



}
