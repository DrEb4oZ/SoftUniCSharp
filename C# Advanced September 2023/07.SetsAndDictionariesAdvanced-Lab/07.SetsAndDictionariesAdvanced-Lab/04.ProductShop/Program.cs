using System.Collections.Specialized;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> citysProductsPrices = new SortedDictionary<string, Dictionary<string, double>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] currentCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!citysProductsPrices.ContainsKey(currentCommand[0]))
                {
                    citysProductsPrices.Add(currentCommand[0], new Dictionary<string, double>());
                }

                citysProductsPrices[currentCommand[0]].Add(currentCommand[1], double.Parse(currentCommand[2]));
            }

            foreach (KeyValuePair<string, Dictionary<string, double>> cityProductPrice in citysProductsPrices)
            {
                Console.WriteLine($"{cityProductPrice.Key}->");
                foreach (KeyValuePair<string,double> productPrice in cityProductPrice.Value)
                {
                    Console.WriteLine($"Product: {productPrice.Key}, Price: {productPrice.Value}");
                }
            }
        }
    }
}