using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car
    {
        public string Fuel { get; set; }
        public int BatteryCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }

       public Car(string fuel, 
            string color, int passengerCapacity)
        {
            Fuel = fuel;
            PassengerCapacity = passengerCapacity;
            Color = color;
        }

        public void GetGas ()
            {
            Console.WriteLine($"The car uses {Fuel}" );
            }

        public void PullUp()
              {
              Console.WriteLine($"He told the connect he drove a {Color} SUV");
              }

        public void Brake()
             {
             Console.WriteLine($"The new Chevy Yukon can hold 8 {PassengerCapacity} in total");
             }

    }
}
