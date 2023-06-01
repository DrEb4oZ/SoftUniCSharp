namespace _10.LadyBugTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] field = new int[fieldSize];

            foreach (int index in ladybugIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladybugIndex >= 0 && ladybugIndex < fieldSize && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0; // Remove the ladybug from its initial position

                    int newPosition = ladybugIndex;
                    while (true)
                    {
                        if (direction == "right")
                        {
                            newPosition += flyLength;
                        }
                        else if (direction == "left")
                        {
                            newPosition -= flyLength;
                        }

                        if (newPosition < 0 || newPosition >= fieldSize)
                        {
                            break; // Ladybug flew out of bounds, stop moving
                        }

                        if (field[newPosition] == 0)
                        {
                            field[newPosition] = 1; // Ladybug landed on an empty cell
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}