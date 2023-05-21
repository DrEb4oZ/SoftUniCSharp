namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}