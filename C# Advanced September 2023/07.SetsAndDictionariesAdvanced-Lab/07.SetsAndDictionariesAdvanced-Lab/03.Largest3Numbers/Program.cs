namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> orderedThreeNumbers = numbers.OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", orderedThreeNumbers));
        }
    }
}