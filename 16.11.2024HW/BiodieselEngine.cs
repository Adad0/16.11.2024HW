using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW.Engines
{
    public class BiodieselEngine : DieselEngine
    {
        public BiodieselEngine(float hp, float fuelConsumptionRate) : base(hp, fuelConsumptionRate)
        {
        }

        public void UseBiodiesel()
        {
            Console.WriteLine("Using biodiesel fuel.");
        }
    }
}
