namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int equalElementCount = 0;
            int equalElementValue = 0;
            int currentElementCount = 0;
            int currentElementValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentElementValue = numbers[i];
                if (i == 0 || currentElementValue == numbers[i - 1])
                {
                    currentElementCount++;
                }
                else
                {
                    currentElementCount = 1;
                }

                if (currentElementCount > equalElementCount)
                {
                    equalElementCount = currentElementCount;
                    equalElementValue = currentElementValue;
                }
            }
            for (int i = 0; i < equalElementCount; i++)
            {
                Console.Write($"{equalElementValue} ");
            }
        }
    }
}