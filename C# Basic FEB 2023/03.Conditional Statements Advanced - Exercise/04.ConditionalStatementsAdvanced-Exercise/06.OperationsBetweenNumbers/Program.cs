using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == '/')
            {
                if (secondNumber == 0)
                {
                    result = 0;
                }
                else
                {
                    result = (double) firstNumber / secondNumber;
                }
            }
            else if (operation == '%')
            {
                if (secondNumber == 0)
                {
                    result = 0;
                }
                else
                {
                    result = firstNumber % secondNumber;
                }
            }
            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - odd");
                }
            }
            else if (operation == '/')
            {
                if (result == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                }
            }
            else if (operation == '%')
            {
                if (result == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
            }
        }
    }
}
