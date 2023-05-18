using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());

            int hours = projectCount * 3;

            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {projectCount} project/s.");
        }
    }
}
