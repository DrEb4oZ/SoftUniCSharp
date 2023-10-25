using System.Net.WebSockets;

namespace _01.ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // daily food Stack
            // daily stamina Queue
            Stack<int> dailyPortions = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> dailyStamina = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            List<string> conqueredPeaks = new List<string>();
            while (dailyPortions.Count > 0)
            {
                int portion = dailyPortions.Pop();
                int stamina = dailyStamina.Dequeue();
                int result = portion + stamina;
                if (conqueredPeaks.Count == 0 && result >= 80)
                {
                    conqueredPeaks.Add("Vihren");
                    continue;
                }

                if (conqueredPeaks.Count == 1 && result >= 90)
                {
                    conqueredPeaks.Add("Kutelo");
                    continue;
                }

                if (conqueredPeaks.Count == 2 && result >= 100)
                {
                    conqueredPeaks.Add("Banski Suhodol");
                    continue;
                }

                if (conqueredPeaks.Count == 3 && result >= 60)
                {
                    conqueredPeaks.Add("Polezhan");
                    continue;
                }

                if (conqueredPeaks.Count == 4 && result >= 70)
                {
                    conqueredPeaks.Add("Kamenitza");
                    continue;
                }

            }

            if (conqueredPeaks.Count == 5)
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (conqueredPeaks.Count > 0)
            {
                Console.WriteLine("Conquered peaks:");
                foreach (string peak in conqueredPeaks)
                {
                    Console.WriteLine(peak);
                }
            }
        }
    }
}