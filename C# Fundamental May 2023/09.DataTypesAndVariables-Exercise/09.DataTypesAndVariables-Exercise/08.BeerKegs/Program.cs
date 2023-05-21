namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            double bestKegVolume = 0;
            string bestKegModel = string.Empty;
            for (int i = 0; i < kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > bestKegVolume)
                {
                    bestKegVolume = kegVolume;
                    bestKegModel = kegModel;
                }

            }
            Console.WriteLine(bestKegModel);
        }
    }
}