using System.Xml.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                Student currentStudent = new Student(name, grade);
                if (!students.ContainsKey(name))
                {
                    students.Add(name, currentStudent);
                }
                else
                {
                    decimal avarageGrade = (currentStudent.AvarageGrade + students[name].AvarageGrade) / 2;
                    currentStudent.AvarageGrade = avarageGrade;
                    students[name] = currentStudent;
                }
            }
            foreach (var kvp in students)
            {
                if (kvp.Value.AvarageGrade >= 4.50m)
                {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.AvarageGrade:f2}");

                }

            }
        }
        public class Student
        {
            public Student(string name, decimal avarageGrade)
            {
                Name = name;
                AvarageGrade = avarageGrade;
            }

            public string Name { get; set; }
            public decimal AvarageGrade { get; set; }
        }
    }
}