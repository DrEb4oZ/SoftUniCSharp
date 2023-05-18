using System;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameTurns = int.Parse(Console.ReadLine());
            double gamePoints = 0;
            int from0To9 = 0, from10To19 = 0, from20To29 = 0, from30To39 = 0, from40To50 = 0, under0Above50 = 0;
            for (int i = 0; i < gameTurns; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    gamePoints /= 2;
                    under0Above50++;
                }
                else if (number <= 9)
                {
                    gamePoints += number * 0.2;
                    from0To9++;
                }
                else if (number <= 19)
                {
                    gamePoints += number * 0.3;
                    from10To19++;
                }
                else if (number <= 29)
                {
                    gamePoints += number * 0.4;
                    from20To29++;
                }
                else if (number <= 39)
                {
                    gamePoints += 50;
                    from30To39++;
                }
                else if (number <= 50)
                {
                    gamePoints += 100;
                    from40To50++;
                }
            }
            Console.WriteLine($"{gamePoints:f2}");
            double from0to9Percentage = (double)from0To9 / gameTurns * 100.00;
            double from10To19Percentage = (double)from10To19 / gameTurns * 100.00;
            double from20To29Percentage = (double)from20To29 / gameTurns * 100.00;
            double from30To39Percentage = (double)from30To39 / gameTurns * 100.00;
            double from40To50Percentage = (double)from40To50 / gameTurns * 100.00;
            double under0Above50Percentage = (double)under0Above50 / gameTurns * 100.00;
            Console.WriteLine($"From 0 to 9: {from0to9Percentage:f2}%");
            Console.WriteLine($"From 10 to 19: {from10To19Percentage:f2}%");
            Console.WriteLine($"From 20 to 29: {from20To29Percentage:f2}%");
            Console.WriteLine($"From 30 to 39: {from30To39Percentage:f2}%");
            Console.WriteLine($"From 40 to 50: {from40To50Percentage:f2}%");
            Console.WriteLine($"Invalid numbers: {under0Above50Percentage:f2}%");

        }
    }
}
