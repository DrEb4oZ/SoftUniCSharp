namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            PrintNxNMatrix(numberInput);

        }
        static void PrintNxNMatrix(int numberInput)
        {
            for (int i = 0; i < numberInput; i++)
            {
                for (int j = 0; j < numberInput; j++)
                {
                    Console.Write(numberInput + " ");
                }
            Console.WriteLine();
            }
        }
    }
}