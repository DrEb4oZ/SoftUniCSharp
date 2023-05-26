namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberCount];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[numbers.Length - 1 - i] + " ");
            //}
            //int[] reverseNumbers = new int[numberCount];
            //reverseNumbers = numbers.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", reverseNumbers));
        }
    }
}