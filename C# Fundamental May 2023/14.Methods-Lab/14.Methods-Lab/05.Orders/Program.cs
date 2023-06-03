namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderedProduct = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            PrintTotalSum(orderedProduct, productQuantity);
        }

        static void PrintTotalSum(string orderedProduct, int productQantity)
        {
            if (orderedProduct == "coffee")
            {
                double result = 1.50 * productQantity;
                Console.WriteLine($"{result:f2}");
            }

            if (orderedProduct == "water")
            {
                double result = 1.00 * productQantity;
                Console.WriteLine($"{result:f2}");
            }

            if (orderedProduct == "coke")
            {
                double result = 1.40 * productQantity;
                Console.WriteLine($"{result:f2}");
            }

            if (orderedProduct == "snacks")
            {
                double result = 2.00 * productQantity;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}