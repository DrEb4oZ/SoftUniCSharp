using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double fuelConsumptionModifier = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override double FuelConsumptionPerKm 
            => base.FuelConsumptionPerKm + fuelConsumptionModifier;

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
