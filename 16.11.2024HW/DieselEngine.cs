using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW.Engines
{
    public class DieselEngine : Engine
    {
        public DieselEngine(float hp, float fuelConsumptionRate)
        {
            _hp = hp;
            _fuelConsumptionRate = fuelConsumptionRate;
        }
    }
}
