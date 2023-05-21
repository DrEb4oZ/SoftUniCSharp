namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spicesMined = 0;
            int dayCount = 0;
            while (startingYield >= 100)
            {
                spicesMined += startingYield;
                startingYield -= 10;
                spicesMined -= 26;
                dayCount++;
            }

            spicesMined -= 26;
            if (spicesMined <= 0)
            {
                spicesMined = 0;
            }

            Console.WriteLine(dayCount);
            Console.WriteLine(spicesMined);
        }
    }
}