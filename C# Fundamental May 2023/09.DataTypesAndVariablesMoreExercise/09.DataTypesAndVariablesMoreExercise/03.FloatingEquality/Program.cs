namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double diff = Math.Abs(number1 - number2);

            bool areEqual = diff <= 0.000001;

            if (areEqual)
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