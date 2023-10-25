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
            //Person oldestPerson = family.GetOldestMember(family);
            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            Family familyMembersAbove30 = family.MoreThan30YearOld();
            foreach (Person person in familyMembersAbove30.FamilyPerson)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}