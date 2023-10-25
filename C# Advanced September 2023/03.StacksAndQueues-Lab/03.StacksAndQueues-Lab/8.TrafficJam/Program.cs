namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightPassingCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCarCount = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }

                else
                {
                    for (int i = 0; i < greenLightPassingCars && cars.Count > 0; i++)
                    {
                        passedCarCount++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCarCount} cars passed the crossroads.");
        }
    }
}