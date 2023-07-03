namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQantityPair = new Dictionary<string, int>();
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourceQantityPair.ContainsKey(resource))
                {
                    resourceQantityPair.Add(resource, quantity);
                }
                else
                {
                    resourceQantityPair[resource] += quantity;
                }
            }
            foreach (var kvp in resourceQantityPair)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}