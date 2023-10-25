namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int memberCount = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < memberCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person currentPerson = new Person(tokens[0], int.Parse(tokens[1]));
                family.AddMember(currentPerson);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}