/*
2 2.6 3 1.6 2 3.6 3 1.6
1 3.3 2 1.6 5 2.4 1 2.2
No more tires
331 2.2
400 2.0
Engines done
Audi A5 2017 200 12 0 0
BMW X5 2027 175 18 1 1
Show special
*/



using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string command = string.Empty;
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 8)
                {
                    Tire[] currentTier = new Tire[4]
                    {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7]))
                    };

                    tires.Add(currentTier);
                }

            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    Engine currentEngine = new Engine(int.Parse(tokens[0]), double.Parse(tokens[1]));
                    engines.Add(currentEngine);

                }
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelCompsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);
                if (tokens.Length == 7 && engineIndex >= 0 && engineIndex < engines.Count && tireIndex >= 0 && tireIndex < tires.Count)
                {
                    Car currentCar = new Car(make, model, year, fuelQuantity, fuelCompsumption, engines[engineIndex], tires[tireIndex]);

                    cars.Add(currentCar);
                }
            }

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(x => (double)x.Pressure) > 9 && car.Tires.Sum(x => (double)x.Pressure) < 10)
                {
                    car.FuelQuantity = car.FuelQuantity - (double)car.FuelConsumption * 20 / 100.0;
                    StringBuilder printResult = new StringBuilder();
                    printResult.AppendLine($"Make: {car.Make}");
                    printResult.AppendLine($"Model: {car.Model}");
                    printResult.AppendLine($"Year: {car.Year}");
                    printResult.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                    printResult.AppendLine($"FuelQuantity: {car.FuelQuantity}");
                    //if (car.FuelQuantity >= 0)
                    //{
                        Console.WriteLine(printResult.ToString().TrimEnd());
                    //}
                }
            }
        }
    }
}