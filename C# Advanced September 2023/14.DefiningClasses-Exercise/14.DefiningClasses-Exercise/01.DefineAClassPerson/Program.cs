namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Person 1";
            firstPerson.Age = 30;

            Person secondPerson = new Person();
            secondPerson.Name = "Person 2";
            secondPerson.Age = 20;

            Console.WriteLine($"Person: {firstPerson.Name} is {firstPerson.Age} old");
            Console.WriteLine($"Person: {secondPerson.Name} is {secondPerson.Age} old");
        }
    }
}