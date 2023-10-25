using System.Reflection;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCounts = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < carsCounts; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionPerKilometer = double.Parse(tokens[2]);

                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
                car.TravelledDistance = 0;
                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }
                cars[model] = car;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                double amountOfKilometers = double.Parse(tokens[2]);
                cars[model].Drive(amountOfKilometers);
            }

            foreach (KeyValuePair<string,Car> car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}