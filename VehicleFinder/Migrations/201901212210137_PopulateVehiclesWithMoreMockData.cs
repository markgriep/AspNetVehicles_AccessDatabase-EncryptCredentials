namespace VehicleFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehiclesWithMoreMockData : DbMigration
    {
        public override void Up()
		{
			InsertMockVehicles();
			InsertMockCustomers();
		}


		private void InsertMockCustomers()
		{
			Sql("INSERT INTO Customers(Name) values('Bram Sanham')");
			Sql("INSERT INTO Customers(Name) values('Emmalyn Dugan')");
			Sql("INSERT INTO Customers(Name) values('Portia Vanstone')");
			Sql("INSERT INTO Customers(Name) values('Cristina Reinbeck')");
			Sql("INSERT INTO Customers(Name) values('Dehlia Reolfi')");
			Sql("INSERT INTO Customers(Name) values('Ronny Jukes')");
			Sql("INSERT INTO Customers(Name) values('Jami Kermon')");
			Sql("INSERT INTO Customers(Name) values('Mendel Luciano')");
			Sql("INSERT INTO Customers(Name) values('Jacklyn Rosling')");
			Sql("INSERT INTO Customers(Name) values('Piotr Le Grand')");
			Sql("INSERT INTO Customers(Name) values('Graham Ambrois')");
			Sql("INSERT INTO Customers(Name) values('Nesta Rangeley')");
			Sql("INSERT INTO Customers(Name) values('Torrence Vise')");
			Sql("INSERT INTO Customers(Name) values('Fionna Plet')");
			Sql("INSERT INTO Customers(Name) values('Alli Longrigg')");
			Sql("INSERT INTO Customers(Name) values('Catarina Martinuzzi')");
			Sql("INSERT INTO Customers(Name) values('Hakim Eldred')");
			Sql("INSERT INTO Customers(Name) values('Perren Dudbridge')");
			Sql("INSERT INTO Customers(Name) values('Pepillo McGarahan')");
			Sql("INSERT INTO Customers(Name) values('Nerta Hawkey')");
			Sql("INSERT INTO Customers(Name) values('Suzy McGann')");
			Sql("INSERT INTO Customers(Name) values('Cassie Wincer')");
			Sql("INSERT INTO Customers(Name) values('Georgiana Pierse')");
			Sql("INSERT INTO Customers(Name) values('Faustine Brainsby')");
			Sql("INSERT INTO Customers(Name) values('Karilynn Madoc-Jones')");
			Sql("INSERT INTO Customers(Name) values('Ed Brendel')");
			Sql("INSERT INTO Customers(Name) values('Cynde Berkeley')");
			Sql("INSERT INTO Customers(Name) values('Maurizio Corr')");
			Sql("INSERT INTO Customers(Name) values('Romeo Harrop')");
		}

		private void InsertMockVehicles()
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



			// Run this on the SQL server that contains your existing data. You will recieve a bunch of "INSERT INTO..." lines that 
			//    you can run via code  (through the Update-Database, in the Up() method) which will populate your new database with mock data
			//
			//
			//  SELECT 'Sql("INSERT INTO Vehicles(VehicleMake, VehicleModel, VehicleYear, ImageUrl)
			//  VALUES ( ''' + VehicleMake + ''', ''' + VehicleModel + ''', ' + CAST(VehicleYear as varchar) + ', ''' + ImageUrl + ''')");'
			//  from Vehicles
		}


		public override void Down()
        {
        }
    }
}
