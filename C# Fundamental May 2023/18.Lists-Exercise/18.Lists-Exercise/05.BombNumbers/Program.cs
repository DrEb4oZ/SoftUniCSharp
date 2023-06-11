namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombParameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bombNumber = bombParameters[0];
            int bombPower = bombParameters[1];
            while (numberSequence.Contains(bombNumber))
            {
                int indexOfBomb = numberSequence.IndexOf(bombNumber);
                if (indexOfBomb - bombPower < 0)
                {
                    numberSequence.RemoveRange(0, indexOfBomb);
                }

                else
                {
                    numberSequence.RemoveRange(indexOfBomb - bombPower, bombPower);
                }

                int indexOfBombSecondExplosion = numberSequence.IndexOf(bombNumber);
                if (indexOfBombSecondExplosion + bombPower > numberSequence.Count - 1)
                {
                    numberSequence.RemoveRange(indexOfBombSecondExplosion + 1, numberSequence.Count - indexOfBombSecondExplosion - 1);
                }

                else
                {
                    numberSequence.RemoveRange(indexOfBombSecondExplosion + 1, bombPower);
                }

                numberSequence.Remove(bombNumber);
            }

            Console.WriteLine(numberSequence.Sum());
        }
    }
}