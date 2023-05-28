namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bestNumber = int.MinValue;
            int bestNumberCount = 0;
            int emptyIterration = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > bestNumber)
                {
                    bestNumber = numbers[i];
                    bestNumberCount++;
                }
            }
            bestNumber = int.MinValue;
            int[] topIntegersArray = new int[bestNumberCount];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > bestNumber)
                {
                    bestNumber = numbers[i];
                    topIntegersArray[numbers.Length - i - 1 - emptyIterration] = bestNumber;
                }
                else
                {
                    emptyIterration++;
                }
            }
            for (int i = 0; i < topIntegersArray.Length; i++)
            {
                Console.Write($"{topIntegersArray[topIntegersArray.Length - i - 1]} ");
            }
        }
    }
}