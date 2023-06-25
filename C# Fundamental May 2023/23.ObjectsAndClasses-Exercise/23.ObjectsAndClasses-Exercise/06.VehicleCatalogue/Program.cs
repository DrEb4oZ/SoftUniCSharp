using System.ComponentModel;
using System.Threading.Channels;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] currentInput = input
                    .Split()
                    .ToArray();
                string type = currentInput[0];
                string model = currentInput[1];
                string color = currentInput[2];
                decimal horsePower = decimal.Parse(currentInput[3]);
                Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(currentVehicle);
            }
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle currentInput = vehicles.FirstOrDefault(v => v.Model == input);
                if (currentInput != null)
                {
                    Console.WriteLine(currentInput);
                }
            }
            decimal averageHP = vehicles
            .Where(v => v.Type == "car")
            .Select(v => v.HorsePower)
            .DefaultIfEmpty()
            .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(v => v.Type == "truck")
                .Select(v => v.HorsePower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public decimal HorsePower { get; set; }

        public override string ToString()
        {
            string captitalizedString = char.ToUpper(Type[0]) + Type.Substring(1);
            return $"Type: {captitalizedString}\n " +
                $"Model: {Model}\n " +
                $"Color: {Color}\n " +
                $"Horsepower: {HorsePower}";
        }
    }
}