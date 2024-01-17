using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double fuelConsumptionModifier = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }
        public override double FuelConsumptionPerKm => base.FuelConsumptionPerKm + fuelConsumptionModifier;
    }
}
