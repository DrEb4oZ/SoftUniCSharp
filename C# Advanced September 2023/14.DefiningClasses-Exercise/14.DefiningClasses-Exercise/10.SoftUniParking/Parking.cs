using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity = 0;

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }
        public List<Car> Cars
        {
            get
            {
                return this.cars;
            }
            set
            {
                this.cars = value;
            }
        }

        public int Count
        {
            get
            {
                return cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            else if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                foreach (Car car in cars.Where(c => c.RegistrationNumber == registrationNumber))
                {
                    cars.Remove(car);
                    break;
                }
                return $"Successfully removed {registrationNumber}";
            }

            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            foreach (Car car in cars.Where(c => c.RegistrationNumber == registrationNumber))
            {
                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine($"Make: {car.Make}");
                //sb.AppendLine($"Model: {car.Model}");
                //sb.AppendLine($"HorsePower: {car.HorsePower}");
                //sb.AppendLine($"RegistrationNumber: {car.RegistrationNumber}");
                //return sb.ToString().TrimEnd();
                return car;
            }
            return null;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                cars.RemoveAll(c => registrationNumbers.Contains(c.RegistrationNumber));
            }
        }
    }
}
