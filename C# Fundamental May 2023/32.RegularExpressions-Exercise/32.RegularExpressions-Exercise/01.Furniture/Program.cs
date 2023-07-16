using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";
            string input;
            List<Furniture> furniture = new List<Furniture>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection furniutres = Regex.Matches(input, regex);
                foreach (Match match in furniutres)
                {
                    Furniture currentFurniture = new Furniture();
                    currentFurniture.Name = match.Groups["furniture"].Value;
                    currentFurniture.Price = decimal.Parse(match.Groups["price"].Value);
                    currentFurniture.Quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(currentFurniture);
                }
            }

            decimal totalSum = 0;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture item in furniture)
            {
                Console.WriteLine(item.Name);
                totalSum += item.TotalPrice();
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
    public class Furniture
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice()
        {
            return Price * Quantity;
        }
    }
}