using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Aircraft : VehicleBase
    {

        public Aircraft(string fuel,
           string color, int passengerCapacity)
        {
            Fuel = fuel;
            PassengerCapacity = passengerCapacity;
            Color = color;
        }

        public void GetGas()
        {
            Console.WriteLine($"The Jet uses {Fuel} from China");
        }

        public void Fly()
        {
            Console.WriteLine("Due to the conroavirus flights are grounded");
        }

        public void Landing()
        {
            Console.WriteLine($"Due to the weather the plane had" +
                $" to make an emergency landing");
        }
    }
}
