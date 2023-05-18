using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failCounter = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int totalScore = 0;
            int countProblems = 0;
            int failedProblems = 0;
            bool isFailed = false;
            string lastProblem = string.Empty;

            while (problemName != "Enough" && !isFailed)
            {
                int score = int.Parse(Console.ReadLine());
                if (score <= 4)
                {
                    failedProblems++;
                    if (failCounter == failedProblems)
                    {
                        isFailed = true;
                    }
                }
                countProblems++;
                totalScore += score;
                lastProblem = problemName;
                problemName = Console.ReadLine();

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failCounter} poor grades.");
            }
            else
            {
                double avarageScore = (double)totalScore / countProblems;
                Console.WriteLine($"Average score: {avarageScore:f2}");
                Console.WriteLine($"Number of problems: {countProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
