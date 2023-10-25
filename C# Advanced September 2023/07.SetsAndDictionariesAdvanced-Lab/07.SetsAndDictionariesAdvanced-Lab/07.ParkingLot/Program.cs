namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string currentCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                string currentCar = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
                switch (currentCommand)
                {
                    case "IN":
                        cars.Add(currentCar);
                        break;
                    case "OUT":
                        cars.Remove(currentCar);
                        break;
                }
            }
            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join("\n", cars));
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}