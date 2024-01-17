using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factory.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();

            while (true)
            {
                string[] animalTokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (animalTokens[0] == "End")
                {
                    break;
                }

                string[] foodTokens = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                IAnimal animal = CreateAnimal(animalTokens);
                IFood food = CreateFood(foodTokens);

                writer.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Feed(food);
                }
                catch (Exception ex)
                {

                    writer.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }
            foreach (var animal in animals)
            {
                writer.WriteLine(animal);
            }
        }

        private IAnimal CreateAnimal(string[] animalTokens)
        {

            return animalFactory.Create(animalTokens);

        }
        private IFood CreateFood(string[] foodTokens)
        {
            return foodFactory.Create(foodTokens);
        }
    }
}
