namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int coursesCount = 0;

            while (peopleCount > 0)
            {
                peopleCount -= elevatorCapacity;
                coursesCount++;
            }
            Console.WriteLine(coursesCount);
        }
    }
}