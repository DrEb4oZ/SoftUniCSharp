using System;

namespace _04.NumbersDividedBy3WithoutReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
