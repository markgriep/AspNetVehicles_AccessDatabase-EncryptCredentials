using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VehicleFinder.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

		// represents the vehicle table in the database.
		// DbContext is aware of the vehicle class with this line in here
		// must run/re-run  add-migration so the db will be updated if you add more 
		// tables.
		// Then run update-database.  
		// It appears that you can run that as many times as you want.
		// For example, you can drop the table and re run and it will recreate it.


	    public DbSet<Vehicle> Vehicles { get; set; }   



		// Change the name of the Dabase here. Currently "VehicleFinder"
        public ApplicationDbContext() : base("VehicleFinder", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}