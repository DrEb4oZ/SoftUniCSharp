namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nameLenghtFilter = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<List<string>, Predicate<string>> print = (names, match) =>
                {
                    foreach (var name in names)
                    {
                        if(match(name))
                        {
                            Console.WriteLine(name);
                        }
                    }
                };

            Predicate<string> filter = name => name.Length <= nameLenghtFilter;

            print(names,filter);
        }
    }
}