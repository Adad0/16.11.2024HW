using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW
{
    public class Wheel
    {
        public string Type { get; }

        public Wheel(string type)
        {
            Type = type;
        }

        public void Rotate()
        {
            Console.WriteLine("Wheel is rotating.");
        }
    }
}
