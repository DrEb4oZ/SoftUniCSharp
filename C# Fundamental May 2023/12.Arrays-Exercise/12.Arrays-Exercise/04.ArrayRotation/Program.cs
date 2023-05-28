namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            int[] rotatedNumbers = new int[numbers.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == numbers.Length - 1)
                    {
                        rotatedNumbers[j] = numbers[0];
                    }

                    else
                    {
                        rotatedNumbers[j] = numbers[j + 1];
                    }

                }
                rotatedNumbers.CopyTo(numbers, 0);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}