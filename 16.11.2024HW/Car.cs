using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW
{
    using _16._11._2024HW.Engines;
    using System;
    using System.Collections.Generic;

    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public Engine Engine { get; }
        public List<Seat> Seats { get; }
        public List<Wheel> Wheels { get; }
        public FuelTank FuelTank { get; }

        public Car(string make, string model, int year, Engine engine, List<Seat> seats, List<Wheel> wheels, FuelTank fuelTank)
        {
            Make = make;
            Model = model;
            Year = year;
            Engine = engine;
            Seats = seats;
            Wheels = wheels;
            FuelTank = fuelTank;
        }

        public void StartCar()
        {
            Engine.Start();
        }

        public void StopCar()
        {
            Engine.Stop();
        }

        public void Drive()
        {
            if (Engine.IsRunning())
            {
                Console.WriteLine("The car is driving.");
                foreach (var wheel in Wheels)
                {
                    wheel.Rotate();
                }
            }
            else
            {
                Console.WriteLine("Start the engine first.");
            }
        }

        public void Refuel(int amount)
        {
            FuelTank.Refuel(amount);
        }

        public void Status()
        {
            Console.WriteLine($"{Make} {Model} ({Year}) - Engine: {(Engine.IsRunning() ? "Running" : "Stopped")}, Fuel Level: {FuelTank.Level} liters");
        }
    }
}
