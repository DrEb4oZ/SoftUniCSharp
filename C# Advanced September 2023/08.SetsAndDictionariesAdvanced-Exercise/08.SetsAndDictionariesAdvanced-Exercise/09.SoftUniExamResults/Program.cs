using System.Collections.Immutable;
/*
Peter-Java-0
George-C#-10
George-C#-0
Sam-C#-0
exam finished

 */
namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> courses = new Dictionary<string, int>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] commandTokens = command
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string studentName = commandTokens[0];
                string action = commandTokens[1];
                if (action == "banned")
                {
                    students.Remove(studentName);
                }

                else
                {
                    int points = int.Parse(commandTokens[2]);
                    if (!students.ContainsKey(studentName))
                    {
                        students.Add(studentName, new Dictionary<string, int>());
                    }

                    if (!students[studentName].ContainsKey(action))
                    {
                        students[studentName].Add(action, 0);
                    }
                    if (!courses.ContainsKey(action))
                    {
                        courses.Add(action, 0);
                    }
                    if (students[studentName][action] > points)
                    {
                        courses[action]++;
                        continue;
                    }
                    students[studentName][action] = points;
                    courses[action]++;
                }
            }

            Dictionary<string, Dictionary<string, int>> orderedStudents = students
            .OrderByDescending(x => x.Value.Values.Max(x => x)).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (KeyValuePair<string, Dictionary<string, int>> student in orderedStudents)
            {
                Console.WriteLine($"{student.Key} | {student.Value.Values.Sum(x => x)}");
            }

            Console.WriteLine("Submissions:");
            foreach (KeyValuePair<string, int> course in courses.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine($"{course.Key} - {course.Value}");
            }
        }
    }
}