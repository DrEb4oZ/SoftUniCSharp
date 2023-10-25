namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int first = 4;
            int second = 4;

            EqualityScale<int> equalityScale = new EqualityScale<int>(first, second);


            Console.WriteLine(equalityScale.AreEqual(first, second));
        }
    }

}
