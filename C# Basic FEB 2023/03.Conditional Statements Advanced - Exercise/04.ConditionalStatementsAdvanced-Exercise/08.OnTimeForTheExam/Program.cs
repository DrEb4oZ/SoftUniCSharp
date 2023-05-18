using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            int examInMinutes = examHour * 60 + examMinutes;
            int arrivalInMinutes = arrivalHour * 60 + arrivalMinutes;
            if (arrivalInMinutes > examInMinutes)
            {
                int lateInMinutes = arrivalInMinutes - examInMinutes;
                if (lateInMinutes <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateInMinutes} minutes after the start");
                }
                else
                {
                    int lateInHours = lateInMinutes / 60;
                    lateInMinutes = lateInMinutes % 60;
                    Console.WriteLine("Late");
                    if (lateInMinutes < 10)
                    {
                        Console.WriteLine($"{lateInHours}:0{lateInMinutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{lateInHours}:{lateInMinutes} hours after the start");
                    }
                }
            }
            
            else if (examInMinutes == arrivalInMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (examInMinutes > arrivalInMinutes)
            {
                int onTimeInMinutes = examInMinutes - arrivalInMinutes;
                if (onTimeInMinutes <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{onTimeInMinutes} minutes before the start");
                }
                else
                {
                    int earlyInMinutes = examInMinutes - arrivalInMinutes;
                    if (earlyInMinutes <= 59)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{earlyInMinutes} minutes before the start");
                    }
                    else
                    {
                        int lateInHours = earlyInMinutes / 60;
                        earlyInMinutes = earlyInMinutes % 60;
                        Console.WriteLine("Early");
                        if (earlyInMinutes < 10)
                        {
                            Console.WriteLine($"{lateInHours}:0{earlyInMinutes} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{lateInHours}:{earlyInMinutes} hours before the start");
                        }
                    }
                }
            }
        }
    }
}
