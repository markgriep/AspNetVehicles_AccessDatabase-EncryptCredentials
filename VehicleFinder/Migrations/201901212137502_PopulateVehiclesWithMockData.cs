namespace VehicleFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehiclesWithMockData : DbMigration
    {
        public override void Up()
        {

			//Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear) VALUES ('Ford','Ranchero',1962, 'https://goo.gl/CTmL17')");
			//Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear) VALUES ('AMC','AMX',1969, 'https://goo.gl/N8u1RN')");
			//Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear) VALUES ('Chevrolet','Camaro',1970, 'https://goo.gl/9pJW1x')");
			//Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear) VALUES ('Plymouth','Scamp',1976, 'https://goo.gl/Xr8Kdk')");

        }
        
        public override void Down()
        {
        }
    }
}
