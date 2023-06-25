namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> persons = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] currentInput = input
                    .Split()
                    .ToArray();
                string name = currentInput[0];
                int iD = int.Parse(currentInput[1]);
                int age = int.Parse(currentInput[2]);
                Person currentPerson = new Person(name, iD, age);

                if (persons.Any(x => x.ID == iD))
                {
                    currentPerson.Age = age;
                    currentPerson.Name = name;
                    continue;
                }

                persons.Add(currentPerson);
            }
            List<Person> orderedByNamePersons = persons.OrderBy(x => x.Age).ToList();
            foreach (Person person in orderedByNamePersons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, int iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public int ID { get; set; }

        public int Age { get; set; }
    }
}