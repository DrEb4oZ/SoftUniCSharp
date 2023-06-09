namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideTwoNumbersRecievedByFactorialOfTwoInt(firstNumber, secondNumber):f2}");

        }

        static double DivideTwoNumbersRecievedByFactorialOfTwoInt(int firstNumber, int secondNumber)
        {
            return CalculateFactorial(firstNumber) / CalculateFactorial(secondNumber);
        }


        static double CalculateFactorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;

        }
    }
}