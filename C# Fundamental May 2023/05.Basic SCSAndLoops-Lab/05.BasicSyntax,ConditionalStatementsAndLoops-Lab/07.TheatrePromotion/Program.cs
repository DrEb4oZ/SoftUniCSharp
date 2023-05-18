namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int custumerAge = int.Parse(Console.ReadLine());
            int ticketPrice = 0;
            bool isAgeValid = true;
            if (typeOfDay == "Weekday")
            {
                if (custumerAge <= 18 && custumerAge >= 0)
                {
                    ticketPrice = 12;
                }
                else if (custumerAge <= 64 && custumerAge > 18)
                {
                    ticketPrice = 18;
                }
                else if (custumerAge <= 122 && custumerAge > 64)
                {
                    ticketPrice = 12;
                }
                else
                {
                    isAgeValid = false;
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (custumerAge <= 18 && custumerAge >= 0)
                {
                    ticketPrice = 15;
                }
                else if (custumerAge <= 64 && custumerAge > 18)
                {
                    ticketPrice = 20;
                }
                else if (custumerAge <= 122 && custumerAge > 64)
                {
                    ticketPrice = 15;
                }
                else
                {
                    isAgeValid = false;
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (custumerAge <= 18 && custumerAge >= 0)
                {
                    ticketPrice = 5;
                }
                else if (custumerAge <= 64 && custumerAge > 18)
                {
                    ticketPrice = 12;
                }
                else if (custumerAge <= 122 && custumerAge > 64)
                {
                    ticketPrice = 10;
                }
                else
                {
                    isAgeValid = false;
                }
            }
            if (isAgeValid)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (!isAgeValid)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}