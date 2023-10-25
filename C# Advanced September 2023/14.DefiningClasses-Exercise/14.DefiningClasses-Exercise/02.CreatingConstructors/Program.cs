namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person firstPerson = new Person();

            Person secondPerson = new Person(20);

            Person thirdPerson = new Person("Person 3", 28);
            Console.WriteLine($"Person: {firstPerson.Name} is {firstPerson.Age} old");
            Console.WriteLine($"Person: {secondPerson.Name} is {secondPerson.Age} old");
            Console.WriteLine($"Person: {thirdPerson.Name} is {thirdPerson.Age} old");
        }
    }
}