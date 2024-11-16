using System;
using System.Collections.Generic;
using _16._11._2024HW;
using _16._11._2024HW.Engines;

namespace _16._11._2024HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BiodieselEngine engine = new BiodieselEngine(200, 5);
            List<Seat> seats = new List<Seat>
            {
                new Seat("Driver"),
                new Seat("Passenger"),
                new Seat("Rear Left"),
                new Seat("Rear Right")
            };
            List<Wheel> wheels = new List<Wheel>
            {
                new Wheel("summer"),
                new Wheel("summer"),
                new Wheel("summer"),
                new Wheel("summer")
            };
            FuelTank fuelTank = new FuelTank(50);

            Car myCar = new Car("Murat", "131", 1980, engine, seats, wheels, fuelTank);

            myCar.StartCar();
            seats[0].Occupy();
            myCar.Drive();
            myCar.Refuel(20);
            myCar.Status();
            myCar.StopCar();
        }
    }
}
