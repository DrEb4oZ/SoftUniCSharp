namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            string.Format(number1, 0.000000);
            string.Format(number2, 0.000000);

            if (number1 == number2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}