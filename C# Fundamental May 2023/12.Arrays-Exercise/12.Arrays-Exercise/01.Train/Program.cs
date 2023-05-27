namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[wagonsCount];
            int sum = 0;
            for (int i = 0; i < peoplePerWagon.Length; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                sum += peoplePerWagon[i];
            }

            Console.WriteLine(string.Join(" ", peoplePerWagon));
            Console.WriteLine(sum);
        }
    }
}