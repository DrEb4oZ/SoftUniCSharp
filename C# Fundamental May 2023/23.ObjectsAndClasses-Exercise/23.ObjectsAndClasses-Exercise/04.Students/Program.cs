using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < studentCount; i++)
            {
                string[] currentStudent = Console.ReadLine()
                    .Split()
                    .ToArray();
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                double grade = double.Parse(currentStudent[2]);
                Students student = new Students(firstName, lastName, grade);
                students.Add(student);
            }
            foreach (Students student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(student.Print());
            }
        }
    }

    public class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public string Print()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}