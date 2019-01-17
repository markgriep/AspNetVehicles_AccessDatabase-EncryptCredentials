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
}
