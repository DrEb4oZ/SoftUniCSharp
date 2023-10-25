namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(CountArray(numbers));
            Console.WriteLine(SumArray(numbers));

        }

        static int SumArray(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static int CountArray(int[] nums)
        {
            int count = 0;

            foreach (int num in nums)
            {
                count ++;
            }
            
            return count;
        }
    }
}