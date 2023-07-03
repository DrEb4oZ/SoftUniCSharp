namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productPricePair = new Dictionary<string, Product>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] currentProduct = command
                    .Split()
                    .ToArray();
                string product = currentProduct[0];
                double price = double.Parse(currentProduct[1]);
                int quantity = int.Parse(currentProduct[2]);
                Product currentProductToAdd = new Product(product, price, quantity);
                if (!productPricePair.ContainsKey(product))
                {
                    productPricePair.Add(product, currentProductToAdd);
                }

                else
                {
                    productPricePair[product].Price = price;
                    productPricePair[product].Quantity += quantity;
                }
            }

            foreach (var kvp in productPricePair)
            {
                Console.WriteLine(kvp.Value);
            }

        }
    }
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double TotalPrice()
        {
            return Price* Quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {TotalPrice():f2}";
        }
    }
}