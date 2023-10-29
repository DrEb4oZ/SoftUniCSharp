using System;
using System.Runtime.ConstrainedExecution;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string animalType = string.Empty;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] currentAnimal = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string animalName = currentAnimal[0];
                int animalAge = int.Parse(currentAnimal[1]);
                string animalGender = currentAnimal[2];
                switch (animalType)
                {
                    case "Cat":
                        Cat cat = new Cat(animalName, animalAge, animalGender);
                        Console.WriteLine(cat);
                        break;

                    case "Dog":
                        Dog dog = new Dog(animalName, animalAge, animalGender);
                        Console.WriteLine(dog);
                        break;

                    case "Frog":
                        Frog frog = new Frog(animalName, animalAge, animalGender);
                        Console.WriteLine(frog);
                        break;

                    case "Kitten":
                        Kitten kitten = new Kitten(animalName, animalAge);
                        Console.WriteLine(kitten);
                        break;

                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(animalName, animalAge);
                        Console.WriteLine(tomcat);
                        break;
                }
            }
            
        }
    }
}
