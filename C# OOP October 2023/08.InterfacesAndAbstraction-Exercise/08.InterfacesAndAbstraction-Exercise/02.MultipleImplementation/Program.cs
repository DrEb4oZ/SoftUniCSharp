using System;

namespace PersonInfo;

public class StartUp
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();

        IIdentifiable personId = new Citizen(name, age, id, birthdate);
        IBirthable personBirthdate = new Citizen(name, age, id, birthdate);

        Console.WriteLine(personId.Id);
        Console.WriteLine(personBirthdate.Birthdate);

    }
}