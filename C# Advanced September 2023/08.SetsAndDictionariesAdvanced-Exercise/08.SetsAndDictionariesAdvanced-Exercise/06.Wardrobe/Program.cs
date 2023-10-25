namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clothesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < clothesCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (!clothes.ContainsKey(input[0]))
                {
                    clothes.Add(input[0], new Dictionary<string, int>());

                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!clothes[input[0]].ContainsKey(input[j]))
                        {
                            clothes[input[0]].Add(input[j], 0);
                        }
                    }
                }

                else
                {
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!clothes[input[0]].ContainsKey(input[j]))
                        {
                            clothes[input[0]].Add(input[j], 0);
                        }
                    }
                }
                for (int j = 1; j < input.Length; j++)
                {
                    clothes[input[0]][input[j]]++;

                }

            }
            string[] lookUpWare = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var ware in clothes)
            {
                Console.WriteLine($"{ware.Key} clothes:");
                foreach (var item in ware.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");


                    if (ware.Key == lookUpWare[0] && item.Key == lookUpWare[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}