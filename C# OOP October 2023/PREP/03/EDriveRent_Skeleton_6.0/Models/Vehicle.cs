using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private double maxMileage;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamaged;

        protected Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            MaxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            batteryLevel = 100;
            isDamaged = false;
        }

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }
                brand = value;
            }
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }

        public double MaxMileage
        {
            get => maxMileage;
            private set
            {
                maxMileage = value;
            }
        }

        public string LicensePlateNumber
        {
            get => licensePlateNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel  //check if it should be protected?
        {
            get => batteryLevel;
            private set
            {
                batteryLevel = value;
            }
        }

        public bool IsDamaged
        {
            get => isDamaged;
            private set
            {
                isDamaged = value;
            }
        }

        public void ChangeStatus()
        {
            if (IsDamaged)
            {
                IsDamaged = false;
            }
            else
            {
                IsDamaged = true;
            }
        }

        public void Drive(double mileage)   // check the math!
        {
            double percentageConsumed = Math.Round(mileage / MaxMileage * 100, 0);
            BatteryLevel = BatteryLevel - (int)percentageConsumed;
            if (this.GetType().Name == "CargoVan")
            {
                BatteryLevel -= 5;
            }
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            if (IsDamaged)
            {
                return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: damaged";
            }
            else
            {
                return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: OK";
            }
        }
    }
}
