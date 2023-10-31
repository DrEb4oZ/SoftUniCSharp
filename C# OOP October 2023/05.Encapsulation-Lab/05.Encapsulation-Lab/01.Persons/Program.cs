namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int personCount = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < personCount; i++)
            {
                string[] personTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = personTokens[0];
                string lastName = personTokens[1];
                int age = int.Parse(personTokens[2]);
                Person person = new Person(firstName, lastName, age);
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}