namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int carsPassedCount = 0;
            while (command != "END")
            {
                int currentGreenLightDuration = greenLightDuration;
                if (command != "green")
                {
                    cars.Enqueue(command);
                }

                else
                {
                    while (cars.Count > 0)
                    {
                        string currentCarName = cars.Peek();
                        int currentCar = cars.Dequeue().Length;
                        if (currentGreenLightDuration > currentCar)
                        {
                            currentGreenLightDuration -= currentCar;
                            carsPassedCount++;
                            continue;
                        }

                        else if (currentGreenLightDuration == currentCar)
                        {
                            carsPassedCount++;
                            break;
                        }

                        else /*if (currentGreenLightDuration < 0)*/
                        {
                            currentGreenLightDuration += freeWindowDuration;
                            if (currentGreenLightDuration >= currentCar)
                            {
                                carsPassedCount++;
                                break;
                            }

                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCarName} was hit at {currentCarName[Math.Abs(currentGreenLightDuration)]}.");
                                return;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassedCount} total cars passed the crossroads.");
        }
    }
}