namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = lostGameCount / 2;
            int mouseCount = lostGameCount / 3;
            int keyboardCount = lostGameCount / 6;
            int displayCount = lostGameCount / 12;

            double totalExpenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayPrice * displayCount;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}