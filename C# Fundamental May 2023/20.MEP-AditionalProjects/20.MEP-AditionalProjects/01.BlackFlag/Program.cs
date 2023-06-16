namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piratingDaysCount = int.Parse(Console.ReadLine());
            int dailyPlunderAmount = int.Parse(Console.ReadLine());
            double expectedPlunderAmount = int.Parse(Console.ReadLine());
            int dayThreeCounter = 0;
            int dayFiveCounter = 0;
            double totalPlunder = 0;
            for (int i = 0; i < piratingDaysCount; i++)
            {
                dayThreeCounter++;
                dayFiveCounter++;
                if (dayThreeCounter == 3 || dayFiveCounter == 5)
                {
                    if (dayThreeCounter == 3)
                    {
                        totalPlunder += dailyPlunderAmount * 1.50;
                        dayThreeCounter = 0;
                    }

                    if (dayFiveCounter == 5)
                    {
                        if (dayThreeCounter != 0)
                        {
                            totalPlunder += dailyPlunderAmount;
                        }

                        totalPlunder = totalPlunder * 0.70;
                        dayFiveCounter = 0;
                    }
                }

                else
                {
                    totalPlunder += dailyPlunderAmount;
                }
            }
            if (totalPlunder >= expectedPlunderAmount)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }

            else
            {
                double percentageLeft = totalPlunder / expectedPlunderAmount * 100;
                Console.WriteLine($"Collected only {percentageLeft:f2}% of the plunder.");
            }
        }
    }
}
