using System.Globalization;
using System.Xml;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isODD = number => number % 2 != 0;

            int[] startEndNum = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string evenOrOdd = Console.ReadLine();
            List<int> numbers = new List<int>();
            for (int i = startEndNum[0]; i <= startEndNum[1]; i++)
            {
                numbers.Add(i);
            }
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                switch (evenOrOdd)
                {
                    case "even":
                        if (isEven(number))
                        {
                            result.Add(number);

                        }
                        break;
                    case "odd":
                        if (isODD(number))
                        {
                            result.Add(number);

                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}