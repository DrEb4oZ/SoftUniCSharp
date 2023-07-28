using System.ComponentModel;

namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] carsTokens = Console.ReadLine()
                    .Split("|");
                string carName = carsTokens[0];
                uint mileage = uint.Parse(carsTokens[1]);
                uint fuel = uint.Parse(carsTokens[2]);
                Car currentCar = new Car(carName, mileage, fuel);
                cars.Add(carName, currentCar);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandTokens = command
                    .Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandTokens[0];
                string currentCarName = commandTokens[1];
                switch (currentCommand)
                {
                    case "Drive":
                        uint distanceToDrive = uint.Parse(commandTokens[2]);
                        uint neededFuel = uint.Parse(commandTokens[3]);
                        Drive(cars, currentCarName, distanceToDrive,neededFuel);
                        break;
                    case "Refuel":
                        uint newFuel = uint.Parse(commandTokens[2]);
                        Refuel(cars, currentCarName, newFuel);
                        break;
                    case "Revert":
                        uint kmToRevert = uint.Parse(commandTokens[2]);
                        Revert(cars, currentCarName, kmToRevert);
                        break;
                }
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static void Revert(Dictionary<string, Car> cars, string currentCarName, uint kmToRevert)
        {
            cars[currentCarName].Mileage -= kmToRevert;
            if (cars[currentCarName].Mileage < 10000)
            {
                cars[currentCarName].Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{cars[currentCarName].Name} mileage decreased by {kmToRevert} kilometers");
            }
        }

        private static void Refuel(Dictionary<string, Car> cars, string currentCarName, uint newFuel)
        {
            uint fuelAdded = 0;
            uint tempFuel = cars[currentCarName].Fuel + newFuel;
            if (tempFuel > 75)
            {
                fuelAdded = 75 - cars[currentCarName].Fuel;
                cars[currentCarName].Fuel = 75;
            }

            else
            {
                fuelAdded = newFuel;
                cars[currentCarName].Fuel += newFuel;
            }

            Console.WriteLine($"{cars[currentCarName].Name} refueled with {fuelAdded} liters");
        }

        private static void Drive(Dictionary<string, Car> cars, string carName,uint distanceToDrive, uint neededFuel)
        {
            if (neededFuel > cars[carName].Fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            
            else
            {
                cars[carName].Mileage += distanceToDrive;
                cars[carName].Fuel -= neededFuel;
                Console.WriteLine($"{cars[carName].Name} driven for {distanceToDrive} kilometers. {neededFuel} liters of fuel consumed.");
                if (cars[carName].Mileage >= 100000)
                {
                    Console.WriteLine($"Time to sell the {cars[carName].Name}!");
                    cars.Remove(carName);
                }
            }
        }
    }
    public class Car
    {
        public Car(string name, uint mileage, uint fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public uint Mileage { get; set; }
        public uint Fuel { get; set; }
    }
}