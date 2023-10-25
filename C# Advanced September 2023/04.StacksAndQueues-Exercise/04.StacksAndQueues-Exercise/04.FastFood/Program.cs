namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersQuantity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(ordersQuantity);
            Console.WriteLine(orders.Max());
            while (orders.Count > 0 && foodQuantity > 0)
            {
                if (orders.Peek() <= foodQuantity)
                {
                    foodQuantity -= orders.Dequeue();
                    //orders.Dequeue();
                }

                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }   
    }
}