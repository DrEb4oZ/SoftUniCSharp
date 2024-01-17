using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factory.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factory
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create(string[] animalTokens)
        {
            IAnimal animal;
            string animalType = animalTokens[0];
            string animalName = animalTokens[1];
            double animalWeight = double.Parse(animalTokens[2]);
            switch (animalType)
            {
                case "Owl":
                    double owlWingSize = double.Parse(animalTokens[3]);
                    return new Owl(animalName, animalWeight, owlWingSize);
                case "Hen":
                    double henWingSize = double.Parse(animalTokens[3]);
                    return new Hen(animalName, animalWeight, henWingSize);
                case "Mouse":
                    string mouseLivingRegion = animalTokens[3];
                    return new Mouse(animalName, animalWeight, mouseLivingRegion);
                case "Dog":
                    string dogLivingRegion = animalTokens[3];
                    return new Dog(animalName, animalWeight, dogLivingRegion);
                case "Cat":
                    string catLivingRegion = animalTokens[3];
                    string catBreed = animalTokens[4];
                    return new Cat(animalName, animalWeight, catLivingRegion, catBreed);
                case "Tiger":
                    string tigerLivingRegion = animalTokens[3];
                    string tigerBreed = animalTokens[4];
                    return new Tiger(animalName, animalWeight, tigerLivingRegion, tigerBreed);
                default:
                    return default;
            }
        }
    }
}
