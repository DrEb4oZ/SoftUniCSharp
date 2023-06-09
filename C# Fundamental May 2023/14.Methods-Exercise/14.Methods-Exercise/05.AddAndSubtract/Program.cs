namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintSumOfFirstTwoSubstractedWithThird(firstNumber, secondNumber, thirdNumber));

        }

        static int PrintSumOfFirstTwoSubstractedWithThird(int firstNumber, int secondNumber, int thirdNumber)
        {
            return SumOfTwoInt(firstNumber, secondNumber) - thirdNumber;
        }

        static int SumOfTwoInt(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}