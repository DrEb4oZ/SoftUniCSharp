namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number.ToString().Length; i++)
            //{
            //    if (i == number.ToString().Length - 1)
            //    {
            //        char lastDigit = number.ToString()[i];
            //        int lastDigitNumericValue = (int)char.GetNumericValue(lastDigit);
            //        if (lastDigitNumericValue == 1)
            //        {
            //            Console.WriteLine("one");
            //        }
            //        else if (lastDigitNumericValue == 2)
            //        {
            //            Console.WriteLine("two");
            //        }

            //        else if (lastDigitNumericValue == 2)
            //        {
            //            Console.WriteLine("two");
            //        }

            //        else if (lastDigitNumericValue == 3)
            //        {
            //            Console.WriteLine("three");
            //        }

            //        else if (lastDigitNumericValue == 4)
            //        {
            //            Console.WriteLine("four");
            //        }

            //        else if (lastDigitNumericValue == 5)
            //        {
            //            Console.WriteLine("five");
            //        }

            //        else if (lastDigitNumericValue == 6)
            //        {
            //            Console.WriteLine("six");
            //        }

            //        else if (lastDigitNumericValue == 7)
            //        {
            //            Console.WriteLine("seven");
            //        }

            //        else if (lastDigitNumericValue == 8)
            //        {
            //            Console.WriteLine("eight");
            //        }

            //        else if (lastDigitNumericValue == 9)
            //        {
            //            Console.WriteLine("nine");
            //        }

            //        else if (lastDigitNumericValue == 0)
            //        {
            //            Console.WriteLine("zero");
            //        }
            //    }
            //}
            int lastDigit = number % 10;
            if (lastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (lastDigit == 2)
            {
                Console.WriteLine("two");
            }

            else if (lastDigit == 2)
            {
                Console.WriteLine("two");
            }

            else if (lastDigit == 3)
            {
                Console.WriteLine("three");
            }

            else if (lastDigit == 4)
            {
                Console.WriteLine("four");
            }

            else if (lastDigit == 5)
            {
                Console.WriteLine("five");
            }

            else if (lastDigit == 6)
            {
                Console.WriteLine("six");
            }

            else if (lastDigit == 7)
            {
                Console.WriteLine("seven");
            }

            else if (lastDigit == 8)
            {
                Console.WriteLine("eight");
            }

            else if (lastDigit == 9)
            {
                Console.WriteLine("nine");
            }

            else if (lastDigit == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}