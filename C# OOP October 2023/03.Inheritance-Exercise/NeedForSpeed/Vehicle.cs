using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private double fuelConsumption;
        private double fuel;
        private int horsePower;
        private double defaultFuelConsumption;
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }


        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }

    }
}
