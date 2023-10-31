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
                try
                {
                    string[] personTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string firstName = personTokens[0];
                    string lastName = personTokens[1];
                    int age = int.Parse(personTokens[2]);
                    decimal salary = decimal.Parse(personTokens[3]);
                    Person person = new Person(firstName, lastName, age, salary);
                    persons.Add(person);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
            decimal percentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}