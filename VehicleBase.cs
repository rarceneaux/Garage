using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    abstract class VehicleBase
    {
        public string Fuel { get; set; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }
    }
}
