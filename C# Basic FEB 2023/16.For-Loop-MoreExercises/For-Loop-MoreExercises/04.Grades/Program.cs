using System;
using System.Diagnostics.Tracing;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double totalEvaluation = 0.00;
            int evaluationUnder3 = 0, evaluationUnder4 = 0, evaluationUnder5 = 0, evaluationUnder6 = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());
                totalEvaluation += evaluation;
                if (evaluation < 3)
                {
                    evaluationUnder3++;
                }
                else if (evaluation < 4)
                {
                    evaluationUnder4++;
                }
                else if (evaluation < 5)
                {
                    evaluationUnder5++;
                }
                else
                {
                    evaluationUnder6++;
                }
            }
            double topStudent = (double)evaluationUnder6 / studentCount * 100;
            double between4And5 = (double)evaluationUnder5 / studentCount * 100;
            double between3And4 = (double)evaluationUnder4 / studentCount * 100;
            double failStudent = (double)evaluationUnder3 / studentCount * 100;
            double avarageEvaluation = totalEvaluation / studentCount;


            Console.WriteLine($"Top students: {topStudent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4And5:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3And4:f2}%");
            Console.WriteLine($"Fail: {failStudent:f2}%");
            Console.WriteLine($"Average: {avarageEvaluation:f2}");
        }
    }
}
