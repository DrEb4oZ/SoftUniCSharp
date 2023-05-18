using System;
using System.Threading.Channels;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            string tournamentPosition = string.Empty;
            int tournamentPoints = 0;
            int tournamentWins = 0;
            for (int i = 0; i < tournamentCount; i++)
            {
                tournamentPosition = Console.ReadLine();
                if (tournamentPosition == "W")
                {
                    tournamentPoints += 2000;
                    tournamentWins +=1;
                }
                else if (tournamentPosition == "F")
                {
                    tournamentPoints += 1200;
                }
                else if (tournamentPosition == "SF")
                {
                    tournamentPoints += 720;
                }
            }
            double totalPoints = tournamentPoints + startPoints;
            double avaragePoints = Math.Floor((double)tournamentPoints / tournamentCount);
            double tournamentsWinsPercentage = (double) tournamentWins / tournamentCount * 100;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {avaragePoints}");
            Console.WriteLine($"{tournamentsWinsPercentage:f2}%");
        }
    }
}
