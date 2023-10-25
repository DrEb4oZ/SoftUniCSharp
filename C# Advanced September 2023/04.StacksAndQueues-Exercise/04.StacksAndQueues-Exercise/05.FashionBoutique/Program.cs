namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(clothes);
            int rackCount = 1;
            int currentRackCapacity = rackCapacity;
            while (clothesStack.Count > 0)
            {
                if (clothesStack.Peek() <= currentRackCapacity)
                {
                    currentRackCapacity -= clothesStack.Pop();
                }

                else
                {
                    rackCount++;
                    currentRackCapacity = rackCapacity;
                    currentRackCapacity -= clothesStack.Pop();
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}