using System;
using System.Net.NetworkInformation;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeArea = cakeWidth * cakeLenght;
            string piecesTaken = Console.ReadLine();
            int piecesCount = 0;
            while (cakeArea > 0 && piecesTaken != "STOP")
            {
                int currentPiecesTaken = int.Parse(piecesTaken);
                cakeArea -= currentPiecesTaken;
                piecesCount += currentPiecesTaken;
                piecesTaken = Console.ReadLine();
            }
            if (cakeArea >= 0)
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
            else
            {
                int neededPieceOfCake = piecesCount - (cakeWidth * cakeLenght);
                Console.WriteLine($"No more cake left! You need {neededPieceOfCake} pieces more.");
            }
        }
    }
}
