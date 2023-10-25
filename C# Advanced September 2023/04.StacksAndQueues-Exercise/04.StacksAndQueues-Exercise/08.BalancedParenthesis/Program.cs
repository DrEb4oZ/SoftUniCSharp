namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openingParenthesis = new Stack<char>();
            bool isParethesisBalanced = true;
            for (int i = 0; i < input.Length && isParethesisBalanced; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    openingParenthesis.Push(input[i]);
                }

                else if (input[i] == ')' && openingParenthesis.Count > 0)
                {
                    if (openingParenthesis.Peek() == '(')
                    {
                        openingParenthesis.Pop();
                    }

                    else
                    {
                        isParethesisBalanced = false;
                    }
                }

                else if (input[i] == ']' && openingParenthesis.Count > 0)
                {
                    if (openingParenthesis.Peek() == '[')
                    {
                        openingParenthesis.Pop();
                    }

                    else
                    {
                        isParethesisBalanced = false;
                    }
                }

                else if (input[i] == '}' && openingParenthesis.Count > 0)
                {
                    if (openingParenthesis.Peek() == '{')
                    {
                        openingParenthesis.Pop();
                    }

                    else
                    {
                        isParethesisBalanced = false;
                    }
                }

                else if (openingParenthesis.Count == 0)
                {
                    isParethesisBalanced = false;
                }
            }

            if (isParethesisBalanced)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}