using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double fuelConsumptionModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override double FuelConsumptionPerKm => base.FuelConsumptionPerKm + fuelConsumptionModifier;

    }
}
