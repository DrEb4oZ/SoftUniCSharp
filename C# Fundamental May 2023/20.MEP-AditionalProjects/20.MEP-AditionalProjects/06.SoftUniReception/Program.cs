namespace _06.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;
            while (studentCount > 0)
            {
                for (int i = 1; i <= 4; i++)
                {
                    hoursNeeded++;
                    if (i != 4)
                    {
                        studentCount -= firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
                    }

                    if (studentCount <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}