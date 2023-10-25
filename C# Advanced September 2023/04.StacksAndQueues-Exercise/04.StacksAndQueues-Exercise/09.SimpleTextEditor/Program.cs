namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> textChanges = new Stack<string>();
            int operationCount = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < operationCount; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split();
                int currentOperation = int.Parse(operation[0]);
                switch (currentOperation)
                {
                    case 1:
                        textChanges.Push(text);
                        string textToAppend = operation[1];
                        text += textToAppend;
                        break;

                    case 2:
                        int textToErrase = int.Parse(operation[1]);
                        if (textToErrase <= text.Length)
                        {
                            textChanges.Push(text);
                            text = text.Substring(0, text.Length - textToErrase);
                        }
                        break;

                    case 3:
                        int indexToReturn = int.Parse(operation[1]) - 1;
                        if (indexToReturn >= 0 && indexToReturn < text.Length)
                        {
                            Console.WriteLine(text[indexToReturn]);
                        }
                        break;

                    case 4:
                        text = textChanges.Pop();
                        break;
                }
            }
        }
    }
}