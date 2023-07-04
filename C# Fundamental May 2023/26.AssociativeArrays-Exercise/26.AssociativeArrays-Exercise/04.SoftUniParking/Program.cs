namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingLotUsers = new Dictionary<string, string>();
            for (int i = 0; i < commandCount; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split()
                    .ToArray();
                string command = currentInput[0];
                string name = currentInput[1];
                if (command == "register")
                {
                    string licensePlateNumber = currentInput[2];
                    if (parkingLotUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                    else
                    {
                        parkingLotUsers.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    if (!parkingLotUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }

                    else
                    {
                        parkingLotUsers.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in parkingLotUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}