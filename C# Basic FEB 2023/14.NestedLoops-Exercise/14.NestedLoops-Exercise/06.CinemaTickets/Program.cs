using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int totalTickets = 0;
            int totalStudentTickets = 0, totalStandardTickets = 0, totalKidTickets = 0;
            while (movieName != "Finish")
            {
                int studentTickets = 0, standardTickets = 0, kidTickets = 0;
                int theaterCapacity = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                
                for (int i = 1; i <= theaterCapacity && ticketType != "End"; i++)
                {
                    if (ticketType == "student")
                    {
                        studentTickets++;
                        totalStudentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                        totalStandardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                        totalKidTickets++;
                    }
                    if (theaterCapacity == i)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                
                double percentTheaterFill = (studentTickets + standardTickets + kidTickets) / (double)theaterCapacity * 100.00;
                Console.WriteLine($"{movieName} - {percentTheaterFill:f2}% full.");

                movieName = Console.ReadLine();
            }
            totalTickets = totalStudentTickets + totalStandardTickets + totalKidTickets;
            double studentTicketsPercent = totalStudentTickets / (double)totalTickets * 100.00;
            double standardTicketsPercent = totalStandardTickets / (double)totalTickets * 100.00 ;
            double kidTicketsPercent = totalKidTickets / (double)totalTickets * 100.00;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
