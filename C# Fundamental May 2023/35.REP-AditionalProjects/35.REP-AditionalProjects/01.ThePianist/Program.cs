using System.ComponentModel;
using System.Net.NetworkInformation;

namespace _01.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
            for (int i = 0; i < piecesCount; i++)
            {
                string rawPieces = Console.ReadLine();
                string[] pieceToken = rawPieces
                    .Split("|");
                string name = pieceToken[0];
                string composer = pieceToken[1];
                string key = pieceToken[2];
                Piece currentPiece = new Piece(name, composer, key);
                pieces.Add(currentPiece.Name, currentPiece);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandTokens = command
                    .Split("|");
                string currentCommand = commandTokens[0];
                string currentPiece = commandTokens[1];
                switch (currentCommand)
                {
                    case "Add":
                        string currentComposer = commandTokens[2];
                        string currentKey = commandTokens[3];
                        Add(pieces,currentPiece, currentComposer, currentKey);
                        break;
                    case "Remove":
                        Remove(pieces,currentPiece);
                        break;
                    case "ChangeKey":
                        string newKey = commandTokens[2];
                        ChangeKey(pieces, currentPiece,newKey);
                        break;
                }
            }

            foreach (Piece piece in pieces.Values)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        private static void ChangeKey(Dictionary<string, Piece> pieces, string currentPiece, string newKey)
        {
            if (pieces.ContainsKey(currentPiece))
            {
                pieces[currentPiece].Key = newKey;
                Console.WriteLine($"Changed the key of {currentPiece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
            }
        }

        private static void Remove(Dictionary<string, Piece> pieces, string currentPiece)
        {
            if (pieces.ContainsKey(currentPiece))
            {
                pieces.Remove(currentPiece);
                Console.WriteLine($"Successfully removed {currentPiece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
            }
        }

        private static void Add(Dictionary<string,Piece> pieces, string currentPiece, string currentComposer, string currentKey)
        {
            if (!pieces.ContainsKey(currentPiece))
            {
                pieces.Add(currentPiece, new Piece(currentPiece, currentComposer,currentKey));
                Console.WriteLine($"{currentPiece} by {currentComposer} in {currentKey} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{currentPiece} is already in the collection!");
            }
        }
    }
    public class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}