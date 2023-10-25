namespace DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int differenceInDays = DateModifier.GetDifferenceInDays(firstDate, secondDate);

            Console.WriteLine(differenceInDays);
        }
    }
}