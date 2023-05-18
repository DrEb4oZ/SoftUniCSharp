using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double allPresentationGrades = 0;
            int totalPresentations = 0;
            while (presentationName != "Finish")
            {
                double totalGrade = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    totalGrade += evaluation;
                }
                double avarageGrade = totalGrade / juryCount;
                Console.WriteLine($"{presentationName} - {avarageGrade:f2}.");
                allPresentationGrades += avarageGrade;
                totalPresentations++;
                presentationName = Console.ReadLine();
            }
            double allPresentationAvarageGrade = allPresentationGrades / totalPresentations;
            Console.WriteLine($"Student's final assessment is {allPresentationAvarageGrade:f2}.");
        }
    }
}
