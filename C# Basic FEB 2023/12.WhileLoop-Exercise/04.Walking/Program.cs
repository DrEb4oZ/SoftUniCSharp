using System;
using System.Linq;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int goalTreshold = 10000;
            int totalSteps = 0;
            bool isSheTired = false;

            while (totalSteps < goalTreshold && !isSheTired)
            {
                string currentSteps = Console.ReadLine();
                if (currentSteps == "Going home")
                {
                    isSheTired = true;
                    currentSteps = Console.ReadLine();
                    totalSteps += int.Parse(currentSteps);
                    continue;
                }
                else
                {
                    totalSteps += int.Parse(currentSteps);
                }
            }
            if (totalSteps >= goalTreshold)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goalTreshold} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goalTreshold - totalSteps} more steps to reach goal.");
            }
        }
    }
}
