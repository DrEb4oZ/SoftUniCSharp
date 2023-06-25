namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentInput = input
                    .Split("/")
                    .ToArray();
                string vehicleType = currentInput[0];
                string brand = currentInput[1];
                string model = currentInput[2];
                if (vehicleType == "Car")
                {
                    int horsePower = int.Parse(currentInput[3]);
                    Cars currentCar = new Cars(brand, model, horsePower);
                    cars.Add(currentCar);
                }
                else if (vehicleType == "Truck")
                {
                    int weight = int.Parse(currentInput[3]);
                    Trucks currentTruck = new Trucks(brand, model, weight);
                    trucks.Add(currentTruck);
                }
            }
            Catalog catalogVehicles = new Catalog(cars, trucks);
            if (catalogVehicles.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Cars car in catalogVehicles.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogVehicles.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Trucks truck in catalogVehicles.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    public class Trucks
    {
        public Trucks(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Cars
    {
        public Cars(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog(List<Cars> cars, List<Trucks> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }

        public List<Cars> Cars { get; set; }

        public List<Trucks> Trucks { get; set; }
    }
}