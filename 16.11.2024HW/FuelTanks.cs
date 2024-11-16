using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW
{
    public class FuelTank
    {
        public int Capacity { get; }
        public int Level { get; private set; }

        public FuelTank(int capacity)
        {
            Capacity = capacity;
            Level = capacity; // Initially, the tank is full
        }

        public void Refuel(int amount)
        {
            if (Level + amount <= Capacity)
            {
                Level += amount;
                Console.WriteLine($"Refueled {amount} liters. Current level: {Level} liters.");
            }
            else
            {
                Console.WriteLine("Can't overfill the tank!");
            }
        }
    }
}
