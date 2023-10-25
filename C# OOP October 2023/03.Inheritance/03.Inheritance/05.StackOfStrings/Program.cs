namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            StackOfStrings strings = new StackOfStrings();

            strings.IsEmpty();
            strings.Push("firstPush");
            strings.Push("secondPush");
            strings.Push("thirdPush");
            strings.Push("fourthPush");
            strings.IsEmpty();

            string[] collection1 = new string[] { "fifthPush", "sixthPush" };
            strings.AddRange(collection1);
            List<string> collection2 = new List<string>()
            {
                "seventhPush",
                "eightPush"
            };
            strings.AddRange(collection2);
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

        }
    }
}