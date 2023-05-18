using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToLook = Console.ReadLine();
            int bookCount = 0;
            string bookPicked = Console.ReadLine();
            bool bookFound = false;
            while (!bookFound && bookPicked != "No More Books")
            {
                if (bookPicked == bookToLook)
                {
                    bookFound = true;
                    continue;
                }
                bookCount++;
                bookPicked = Console.ReadLine();
            }
            if (bookFound)
                Console.WriteLine($"You checked {bookCount} books and found it.");
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}
