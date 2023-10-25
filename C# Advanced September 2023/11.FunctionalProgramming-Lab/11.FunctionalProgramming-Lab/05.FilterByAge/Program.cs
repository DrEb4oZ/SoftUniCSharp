namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int personCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < personCount; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = currentPerson[0];
                person.Age = int.Parse(currentPerson[1]);
                people.Add(person);
            }
            string filterType = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string formatType = Console.ReadLine();
            Func<Person, bool> filter = GetFilter(filterType, ageFilter);

            people = people.Where(filter).ToList();

            Action<Person> printer = GetPrinter(formatType);

            foreach (var person in people)
            {
                printer(person);
            }



            Func<Person, bool> GetFilter(string filterType, int age)
            {
                switch (filterType)
                {
                    case "older":
                        return person =>
                    person.Age >= age;
                    case "younger": return person => person.Age < age;
                    default:
                        return null;
                }
            }

            Action<Person> GetPrinter(string formatType)
            {
                switch (formatType)
                {
                    case "name age":
                        return p => Console.WriteLine($"{p.Name} - {p.Age}");
                    case "age":
                        return p => Console.WriteLine($"{p.Age}");
                    case "name":
                        return p => Console.WriteLine($"{p.Name}");
                    default:
                        return null;
                }
            }
        }


        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }
    }
}