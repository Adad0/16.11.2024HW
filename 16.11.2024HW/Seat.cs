using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW
{
    public class Seat
    {
        public string Position { get; }
        public bool Occupied { get; private set; }

        public Seat(string position)
        {
            Position = position;
            Occupied = false;
        }

        public void Occupy()
        {
            Occupied = true;
            Console.WriteLine($"{Position} seat is now occupied.");
        }

        public void Vacate()
        {
            Occupied = false;
            Console.WriteLine($"{Position} seat is now vacant.");
        }
    }
}
