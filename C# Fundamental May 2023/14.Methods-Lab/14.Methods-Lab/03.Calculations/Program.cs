using System.Security.AccessControl;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operationType = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (operationType == "add")
            {
                OperationAdd(firstNumber, secondNumber);
            }

            else if (operationType == "multiply")
            {
                OperationMultiply(firstNumber, secondNumber);
            }

            else if (operationType == "subtract")
            {
                OperationSubtract(firstNumber, secondNumber);
            }

            else if (operationType == "divide")
            {
                OperationDivide(firstNumber, secondNumber);
            }

        }

        static void OperationAdd(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        static void OperationMultiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        static void OperationSubtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        static void OperationDivide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }

    }
}