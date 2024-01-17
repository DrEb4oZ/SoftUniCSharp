using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }

        double TankCapacity { get; }

        string Drive(double distance);

        string Drive(double distance, string driveEmpty);
        void Refuel(double fuelAmount);

    }
}
