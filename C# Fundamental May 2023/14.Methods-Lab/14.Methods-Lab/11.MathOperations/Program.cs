namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operationType = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculationBasedOnType(firstNumber, operationType, secondNumber));
        }

        static double CalculationBasedOnType(double firstNumber, char operationType, double secondNumber)
        {
            double result = 0;
            switch (operationType)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}