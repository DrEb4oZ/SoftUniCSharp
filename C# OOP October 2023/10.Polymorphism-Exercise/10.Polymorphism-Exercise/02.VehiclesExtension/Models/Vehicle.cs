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
    public abstract class Vehicle : IVehicle
    {
        private const double busFuelConsumptionModifier = 1.4;
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double tankCapacity;
        private IWriter writer = new ConsoleWriter();

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (TankCapacity < value)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumptionPerKm
        {
            get => fuelConsumptionPerKm;
            private set
            {
                fuelConsumptionPerKm = value;
            }
        }

        public double TankCapacity
        {
            get => tankCapacity;
            private set
            {
                tankCapacity = value;
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

        public string Drive(double distance, string driveEmpty)
        {
            if (distance * (FuelConsumptionPerKm - busFuelConsumptionModifier) > FuelQuantity)
            {
                return $"{GetType().Name} needs refueling";
            }
            else if (driveEmpty == "DriveEmpty")
            {
                FuelQuantity -= distance * (FuelConsumptionPerKm - busFuelConsumptionModifier);
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return default;
            }
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                writer.WriteLine("Fuel must be a positive number");
            }
            else if (TankCapacity - FuelQuantity >= fuelAmount)
            {
                FuelQuantity += fuelAmount;
            }
            else
            {
                writer.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
