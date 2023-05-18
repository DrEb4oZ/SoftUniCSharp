using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pageCount = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int dayCount = int.Parse(Console.ReadLine());

            int hoursPerDay = (pageCount / pagePerHour) / dayCount;

            Console.WriteLine(hoursPerDay);
        }
    }
}
