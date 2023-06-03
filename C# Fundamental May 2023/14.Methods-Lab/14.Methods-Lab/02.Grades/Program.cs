namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            switch (grade)
            {
                case < 3.00:
                        Console.WriteLine("Fail");
                    break;
                case < 3.50:
                        Console.WriteLine("Poor");
                    break;
                case < 4.50:
                        Console.WriteLine("Good");
                    break;
                case < 5.50:
                    Console.WriteLine("Very good");
                    break;
                case <= 6.00:
                    Console.WriteLine("Excellent");
                    break;
            }
        }
    }
}