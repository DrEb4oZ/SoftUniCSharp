namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int startPosition = int.Parse(Console.ReadLine());
            if (startPosition > 10)
            {
                int product = multiplier * startPosition;
                Console.WriteLine($"{multiplier} X {startPosition} = {product}");
            }
            else
            {
                for (int i = startPosition; i <= 10; i++)
                {
                    int product = multiplier * i;
                    Console.WriteLine($"{multiplier} X {i} = {product}");
                }
            }
        }
    }
}