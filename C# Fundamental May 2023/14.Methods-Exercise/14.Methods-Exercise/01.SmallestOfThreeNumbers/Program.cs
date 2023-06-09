namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNumbers(firstNumber, secondNumber, thirdNumber));
        }

        static int SmallestOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int currentSmallestNumber = Math.Min(firstNumber, secondNumber);
            return Math.Min(currentSmallestNumber, thirdNumber);
        }
    }
}