namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int elemetToLook = input[2];
            int[] elemets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(elementsToEnqueue)
                .ToArray();
            Queue<int> queueElemets = new Queue<int>(elemets);
            for (int i = 0; i < elementsToDequeue && queueElemets.Count > 0; i++)
            {
                queueElemets.Dequeue();
            }

            if (queueElemets.Contains(elemetToLook))
            {
                Console.WriteLine("true");
            }

            else if (queueElemets.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(queueElemets.Min());
            }
        }
    }
}