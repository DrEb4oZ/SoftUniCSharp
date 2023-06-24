namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Console.ReadLine()
                .Split()
                .ToArray();
            Random rnd = new Random();
            for (int i = 0; i < stringInput.Length; i++)
            {
                int swapIndex = rnd.Next(0, stringInput.Length);
                string tempString = stringInput[i];
                stringInput[i] = stringInput[swapIndex];
                stringInput[swapIndex] = tempString; 
            }
            foreach (string input in stringInput)
            {
                Console.WriteLine(input);
            }
        }
    }
}