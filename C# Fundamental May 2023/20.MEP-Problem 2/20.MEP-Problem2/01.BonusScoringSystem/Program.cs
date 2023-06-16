namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());
            double bestBonuse = 0;
            int bestAttendace = 0;
            for (int i = 0; i < studentCount; i++)
            {
                int countOfAttendance = int.Parse(Console.ReadLine());
                double currentStudentBonus = (double)countOfAttendance / lecturesCount * (5 + aditionalBonus);
                if (bestBonuse < currentStudentBonus)
                {
                    bestBonuse = currentStudentBonus;
                    bestAttendace = countOfAttendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonuse)}.");
            Console.WriteLine($"The student has attended {bestAttendace} lectures.");
        }
    }
}