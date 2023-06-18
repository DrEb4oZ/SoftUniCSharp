namespace _03.DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deckOfCards = Console.ReadLine()
                .Split(", ")
                .ToList();
            int numberOfIterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfIterations; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                if (command[0] == "Add")
                {
                    if (!deckOfCards.Contains(command[1]))
                    {
                        deckOfCards.Add(command[1]);
                        Console.WriteLine("Card successfully added");
                    }

                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }

                else if (command[0] == "Remove")
                {
                    if (deckOfCards.Contains(command[1]))
                    {
                        deckOfCards.Remove(command[1]);
                        Console.WriteLine("Card successfully removed");
                    }

                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }

                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < deckOfCards.Count)
                    {
                        deckOfCards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }

                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }

                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < deckOfCards.Count)
                    {
                        if (!deckOfCards.Contains(command[2]))
                        {
                            deckOfCards.Insert(index, command[2]);
                            Console.WriteLine("Card successfully added");
                        }

                        else
                        {
                            Console.WriteLine("Card is already added");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", deckOfCards));
        }
    }
}