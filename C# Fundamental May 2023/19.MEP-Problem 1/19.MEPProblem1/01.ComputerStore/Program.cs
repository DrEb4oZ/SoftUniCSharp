namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order;
            double sumBeforeTaxes = 0;
            while ((order = Console.ReadLine()) != "special" && order != "regular")
            {
                double priceOfElement = double.Parse(order);
                if (priceOfElement < 0)
                {
                    Console.WriteLine($"Invalid price!");
                }

                else
                {
                    sumBeforeTaxes += priceOfElement;
                }
            }

            double sumAfterTaxes = sumBeforeTaxes * 1.20;
            if (order == "special")
            {
                sumAfterTaxes *= 0.90;
            }

            if (sumAfterTaxes == 0)
            {
                Console.WriteLine($"Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumBeforeTaxes:f2}$");
                Console.WriteLine($"Taxes: {sumBeforeTaxes * 0.20:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sumAfterTaxes:f2}$");
            }
        }
    }
}