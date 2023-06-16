namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();
            int cupidPosition = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] currentJump = command
                    .Split()
                    .ToArray();
                int jumpLenght = int.Parse(currentJump[1]);
                cupidPosition += jumpLenght;
                if (cupidPosition >= input.Count)
                {
                    cupidPosition = 0;
                }
                input[cupidPosition] -= 2;
                if (input[cupidPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                }
                if (input[cupidPosition] < 0)
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                }
            }

            bool isCupidSucceded = true;
            int failedHouses = 0;
            foreach (int house in input)
            {
                if (house > 0)
                {
                    isCupidSucceded = false;
                    failedHouses++;
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidPosition}.");
            if (isCupidSucceded)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}