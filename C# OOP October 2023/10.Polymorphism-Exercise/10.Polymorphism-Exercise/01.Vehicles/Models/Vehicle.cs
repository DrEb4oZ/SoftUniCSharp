using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumptionPerKm
        {
            get => fuelConsumptionPerKm;
            private set
            {
                fuelConsumptionPerKm = value;
            }
        }

        public string Drive(double distance)
        {
            if (distance * FuelConsumptionPerKm > FuelQuantity)
            {
                return $"{GetType().Name} needs refueling";
            }
            else
            {
                FuelQuantity -= distance * FuelConsumptionPerKm;
                return $"{GetType().Name} travelled {distance} km";
            }
        }

        public virtual void Refuel(double fuelAmount)
        {
            FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
