using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double fuelConsumptionModifier = 1.6;
        private IWriter writer = new ConsoleWriter();

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override double FuelConsumptionPerKm 
            => base.FuelConsumptionPerKm + fuelConsumptionModifier;

        public override void Refuel(double fuelAmount)
        {
            //base.Refuel(fuelAmount * 0.95);  //possible bug!!! aaaand yes there was a bug
            if (fuelAmount <= 0)
            {
                writer.WriteLine("Fuel must be a positive number");
            }
            else if (TankCapacity - base.FuelQuantity >= fuelAmount)
            {
                base.FuelQuantity += fuelAmount * 0.95;
            }
            else
            {
                writer.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
            }
        }
    }
}
