namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> studentsGrades = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < gradesCount; i++)
            {
                string[] studentGrade = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!studentsGrades.ContainsKey(studentGrade[0]))
                {
                    studentsGrades.Add(studentGrade[0], new List<decimal>());
                }

                studentsGrades[studentGrade[0]].Add(decimal.Parse(studentGrade[1]));
            }

            foreach (KeyValuePair<string,List<decimal>> item in studentsGrades)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => $"{x:f2}"))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}