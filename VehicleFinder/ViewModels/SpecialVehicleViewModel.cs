using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFinder.Models;

namespace VehicleFinder.ViewModels
{
    public class SpecialVehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
