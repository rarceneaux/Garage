using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Watercraft
    {
        public string Fuel { get; set; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }

        public Watercraft(string fuel,
     string color, int passengerCapacity)
        {
            Fuel = fuel;
            PassengerCapacity = passengerCapacity;
            Color = color;
        }
        public void GetGas()
        {
            Console.WriteLine($"Elon made the ship for Mars so it" +
                $"need no {Fuel}");
        }

        public void PullUp()
        {
            Console.WriteLine("The jets on the watercraft are extremely silent");
        }
    }
}
