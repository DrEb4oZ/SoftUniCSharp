using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Factories.Inferfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        private const string InvalidVehicleTypeException = "Invalid vehicle type";
        public IVehicle Create(string type, double fuelQuantity, double fuelConsumptionPerKm)
        {
            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumptionPerKm);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumptionPerKm);
                default:
                    throw new ArgumentException(InvalidVehicleTypeException);
            }
        }
    }
}
