namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, string[]> names = (titel, names) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{titel} {name}");
                }
            };

            string[] namesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            names("Sir", namesInput);
        }
    }
}