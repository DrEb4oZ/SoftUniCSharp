using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosenStrenght = 0;
            int leftExplosenStrenght = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == '>')
                {
                    explosenStrenght += int.Parse(input[i].ToString());
                }
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    continue;
                }
                if (explosenStrenght == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    explosenStrenght--;
                }
            }

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}