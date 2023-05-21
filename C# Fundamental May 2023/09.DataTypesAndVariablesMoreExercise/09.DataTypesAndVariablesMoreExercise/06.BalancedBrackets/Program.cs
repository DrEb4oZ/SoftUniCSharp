namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            bool char40 = false;
            bool char41 = false;
            bool isUnbalanced = false;
            for (int i = 0; i < inputCount && !isUnbalanced; i++)
            {
                string currentInput = Console.ReadLine();
                if (currentInput.Length == 1)
                {
                    char currentChar = char.Parse(currentInput);

                    if (char40 && char41)
                    {
                        char40 = false;
                        char41 = false;
                    }

                    if (!char40 && !char41 && currentChar == 40)
                    {
                        char40 = true;
                    }

                    else if (!char40 && !char41 && currentChar == 41)
                    {
                        isUnbalanced = true;
                    }

                    else if (char40 && !char41 && currentChar == 40)
                    {
                        isUnbalanced = true;
                    }

                    else if (char40 && !char41 && currentChar == 41)
                    {
                        char41 = true;
                    }
                    
                }
                
            }
            if (char40 && !char41)
            {
                isUnbalanced = true;
            }
            if (isUnbalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }

        }
    }
}