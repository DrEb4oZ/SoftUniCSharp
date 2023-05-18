using System;

namespace _08.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMin = int.Parse(Console.ReadLine());
            int N1 = examHour * 60;
            int result1 = N1 + examMins;
            int N2 = arrivingHour * 60;
            int result2 = N2 + arrivingMin;
            bool isGreater = result1 - result2 <= 30;
            bool isGreater2 = result1 - result2 > 30;
            if (result2 > result1)
            {
                Console.WriteLine("Late");
                bool diff = result2 - result1 <= 59;
                bool dif = result2 - result1 > 59;
                int diff1 = result2 - result1;
                if (diff == true)
                {
                    Console.WriteLine($"{diff1} minutes after the start");
                }
                else if (dif == true)
                {
                    int hh = diff1 / 60;
                    int mm = diff1 % 60;
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm} hours after the start");
                    }
                }
            }
            else if (result1 == result2)
            {
                Console.WriteLine("On time");
            }
            else if (isGreater == true)
            {
                Console.WriteLine("On time");
                int diff1 = result1 - result2;
                Console.WriteLine($"{diff1} minutes before the start");
            }
            else if (isGreater2 == true)
            {
                Console.WriteLine("Early");
                bool diff = result1 - result2 <= 59;
                bool dif = result1 - result2 > 59;
                int diff1 = result1 - result2;
                if (diff == true)
                {
                    Console.WriteLine($"{diff1} minutes before the start");
                }
                else if (dif == true)
                {
                    int hh = diff1 / 60;
                    int mm = diff1 % 60;
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm} hours before the start");
                    }

                    else
                    {
                        Console.WriteLine($"{hh}:{mm} hours before the start");
                    }
                }
            }
        }
    }
}