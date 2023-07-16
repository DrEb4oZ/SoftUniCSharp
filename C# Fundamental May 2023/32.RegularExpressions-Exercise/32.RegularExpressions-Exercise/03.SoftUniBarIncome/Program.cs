using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string regex = @"%(?<custumer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)[^|$%.]*\|[^|$%.]*?(?<price>\d+|\d+\.\d+)[^|$%.]*\$";
            List<Order> orders = new List<Order>();
            decimal totalIncome = 0m;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection ordersMatches = Regex.Matches(input, regex);
                foreach (Match order in ordersMatches)
                {
                    Order currentOrder = new Order();
                    currentOrder.CustumerName = order.Groups["custumer"].Value;
                    currentOrder.Product = order.Groups["product"].Value;
                    currentOrder.Quantity = uint.Parse(order.Groups["quantity"].Value);
                    currentOrder.Price = decimal.Parse(order.Groups["price"].Value);
                    orders.Add(currentOrder);
                    Console.WriteLine($"{currentOrder.CustumerName}: {currentOrder.Product} - {currentOrder.TotalPrice():f2}");
                    totalIncome += currentOrder.TotalPrice();
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
    public class Order
    {
        public string CustumerName { get; set; }
        public string Product { get; set; }

        public uint Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal TotalPrice()
        {
            return Quantity * Price;
        }
    }
}