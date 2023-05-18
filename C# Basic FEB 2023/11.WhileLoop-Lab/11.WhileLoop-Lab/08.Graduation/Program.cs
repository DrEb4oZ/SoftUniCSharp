using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int classCount = 1;
            int failCount = 0;
            double evaluationSum = 0;
            while (classCount <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation < 4)
                {
                    failCount += 1;
                    if (failCount == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {classCount} grade");
                        return;
                    }
                    continue;
                }
                classCount += 1;
                evaluationSum += evaluation;
            }
            double avarageGrade = evaluationSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {avarageGrade:f2}");
        }
    }
}
