 using System;
using System.Collections.Generic;

namespace Garage
{
    class Program 
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            var airforce1 = new Aircraft("mid", "white", 7);
            var spaceBalls = new Aircraft("mid", "string", 6);
            var aircrafts = new List<Aircraft> {airforce1,spaceBalls};
            // With a single `foreach`, have each vehicle Fly()
            foreach (var aircraft in aircrafts)
            {
                aircraft.Fly();
            }


            // Build a collection of all vehicles that operate on roads
            var thewip = new Car("high", "black", 4);
            var truck = new Car("diesel", "red", 4);
            var cars = new List<Car> { thewip, truck };

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var car in cars)
            {
                car.PullUp();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
