namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> reversedNumbers = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    reversedNumbers.Add(numbers[i]);
                }
                return reversedNumbers;
            };
            Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, match) =>
            {
                List<int> revAndExcl = new List<int>();
                foreach (var number in numbers)
                {
                    if (!match(number))
                    {
                        revAndExcl.Add(number);

                    }
                }
                return revAndExcl;
            };

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> excluder = number => number % divider == 0;
            numbers = reverse(numbers);
            numbers = exclude(numbers.ToList(), excluder);
            Console.WriteLine(string.Join(" ", numbers.ToList()));
        }
    }
}