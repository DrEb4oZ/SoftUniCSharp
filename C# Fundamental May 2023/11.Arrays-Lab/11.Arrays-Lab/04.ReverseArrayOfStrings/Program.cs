namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine()
                .Split();

            //for (int i = arrString.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arrString[i] + " ");
            //}
            for (int i = 0; i < arrString.Length / 2; i++)
            {
                string startChar = arrString[i];
                string endChar = arrString[arrString.Length - 1 - i];
                arrString[i] = endChar;
                arrString[arrString.Length - 1 - i] = startChar;
            }

            Console.WriteLine(string.Join(" ", arrString));
        }
    }
}