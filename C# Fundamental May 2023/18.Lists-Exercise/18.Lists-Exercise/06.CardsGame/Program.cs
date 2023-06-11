using System.Collections.Generic;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    WinnerTakesLooserCard(firstPlayerCards, secondPlayerCards);
                }
                
                else if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    WinnerTakesLooserCard(secondPlayerCards, firstPlayerCards);
                }

                else if (firstPlayerCards[0] == secondPlayerCards[0])
                {
                    DrawBothLoseCards(firstPlayerCards, secondPlayerCards);
                }
            }

            if (firstPlayerCards.Count != 0)
            {
                int sum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                {
                    int sum = secondPlayerCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                }
            }
        }


        static void WinnerTakesLooserCard(List<int> winnerDeck, List<int> looserDeck)
        {
            winnerDeck.Add(looserDeck[0]);
            winnerDeck.Add(winnerDeck[0]);
            winnerDeck.Remove(winnerDeck[0]);
            looserDeck.Remove(looserDeck[0]);
        }
        static void DrawBothLoseCards(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            firstPlayerCards.Remove(firstPlayerCards[0]);
            secondPlayerCards.Remove(secondPlayerCards[0]);
        }
    }
}