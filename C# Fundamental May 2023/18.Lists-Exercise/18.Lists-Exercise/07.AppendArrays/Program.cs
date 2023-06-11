namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> integersList = Console.ReadLine()
                .Split("|")
                .ToList();
            string tempString = "";
            for (int i = 0; i < integersList.Count; i++)
            {
                tempString += integersList[integersList.Count - i - 1] + " ";
            }

            List<int> resultList = tempString
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}