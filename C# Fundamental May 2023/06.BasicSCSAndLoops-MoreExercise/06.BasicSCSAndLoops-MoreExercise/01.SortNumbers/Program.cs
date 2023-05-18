namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            //int[] numbers1To3 = new int[] { number1, number2, number3 };
            //Array.Sort(numbers1To3);
            //Array.Reverse(numbers1To3);
            //Array.ForEach(numbers1To3, Console.WriteLine);

            if (number1 >= number2 && number1 >= number3)
            {
                firstNumber = number1;
            }

            else if (number2 >= number1 && number2 >= number3)
            {
                firstNumber = number2;
            }

            else if (number3 >= number1 && number3 >= number2)
            {
                firstNumber = number3;
            }

            if (number1 <= number2 && number1 <= number3)
            {
                thirdNumber = number1;
            }

            else if (number2 <= number1 && number2 <= number3)
            {
                thirdNumber = number2;
            }

            else if (number3 <= number1 && number3 <= number2)
            {
                thirdNumber = number3;
            }

            if (firstNumber == number1 && thirdNumber == number2)
            {
                secondNumber = number3;
            }

            else if (firstNumber == number1 && thirdNumber == number3)
            {
                secondNumber = number2;
            }

            else if (firstNumber == number2 && thirdNumber == number1)
            {
                secondNumber = number3;
            }

            else if (firstNumber == number2 && thirdNumber == number3)
            {
                secondNumber = number1;
            }

            else if (firstNumber == number3 && thirdNumber == number2)
            {
                secondNumber = number1;
            }

            else if (firstNumber == number3 && thirdNumber == number1)
            {
                secondNumber = number2;
            }

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}