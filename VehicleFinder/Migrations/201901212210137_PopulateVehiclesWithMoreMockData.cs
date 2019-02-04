namespace VehicleFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehiclesWithMoreMockData : DbMigration
    {
        public override void Up()
        {
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ('Ford'     ,'Ranchero'   ,1962, 'https://goo.gl/CTmL17')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ('AMC'      ,'AMX'        ,1969, 'https://goo.gl/N8u1RN')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ('Chevrolet','Camaro'     ,1970, 'https://goo.gl/9pJW1x')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ('Plymouth' ,'Scamp'      ,1976, 'https://goo.gl/Xr8Kdk')");

			Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Ford', 'Ranchero', 1962, 'https://goo.gl/CTmL17')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'AMC', 'AMX', 1969, 'https://cdn.silodrome.com/wp-content/uploads/2016/02/AMC-AMX-Car-21.jpg')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Chevrolet', 'Camaro', 1970, 'https://goo.gl/9pJW1x')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Plymouth', 'Scamp', 1976, 'https://goo.gl/Xr8Kdk')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Plymouth ', 'Voyager', 1998, 'https://goo.gl/pU8L12')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Honda', 'Del Sol', 1993, 'https://goo.gl/GsrDXW')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Chevrolet', 'Chevette', 1986, 'https://goo.gl/sntR1u')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'AMC', 'Rebel', 1969, 'https://goo.gl/b2dBFT')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Plymouth', 'Volare', 1976, 'http://www.collectorcarads.com/Picture1/DSCN0216.jpg')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Honda', 'Civic', 1976, 'https://i.pinimg.com/736x/36/11/f7/3611f7889e977e791b15633af1cf6823.jpg')");
	        Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl) VALUES ( 'Honda', 'Civic', 2012, 'https://proxy.duckduckgo.com/iu/?u=http%3A%2F%2Fst.motortrend.com%2Fuploads%2Fsites%2F10%2F2015%2F09%2F2012-honda-civic-EX-side.jpg&f=1')");


			// This command, run on SQL, will pull data from the existing table.
			//	    SELECT ' INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl)
			//       VALUES ( ''' + VehicleMake + ''', ' + VehicleModel + ''', ''' + CAST(VehicleYear as varchar) + ''', ''' + ImageUrl + ''')'  from Vehicles


		}

		public override void Down()
        {
        }
    }
}
