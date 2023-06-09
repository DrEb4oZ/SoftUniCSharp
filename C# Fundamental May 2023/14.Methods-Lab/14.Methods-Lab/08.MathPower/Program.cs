namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberBase = double.Parse(Console.ReadLine());
            double numberPower = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPowerOfNumber(numberBase, numberPower));
        }

        static double MathPowerOfNumber (double numberBase, double numberPower)
        {
            return Math.Pow(numberBase, numberPower);
        }
    }
}