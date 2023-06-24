namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentInformation;
            List<Students> students = new List<Students>();
            while ((studentInformation = Console.ReadLine()) != "end")
            {
                string[] currentStudentInput = studentInformation
                    .Split(" ")
                    .ToArray();
                string firstName = currentStudentInput[0];
                string lastName = currentStudentInput[1];
                int age = int.Parse(currentStudentInput[2]);
                string homeTown = currentStudentInput[3];
                Students currentStudent = new Students(firstName, lastName, age, homeTown);
                students.Add(currentStudent);
            }
            
            string cityName = Console.ReadLine();
            List<Students> filteredByCityNameStudents = students.Where(s => s.HomeTown == cityName).ToList();
            foreach (Students student in filteredByCityNameStudents)
            {
                Console.WriteLine(student.Print());
                //Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."); //variation without Method
            }
        }
    }

    class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public string Print()
        {
            string result = $"{FirstName} {LastName} is {Age} years old.";
            return result;
        }

    }
}