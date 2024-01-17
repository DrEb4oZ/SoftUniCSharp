using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private IWriter writer;
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        protected abstract double WeightModifier { get; }

        protected abstract IReadOnlyCollection<string> PreferredFoodTypes { get; }

        public abstract string ProduceSound();

        public void Feed(IFood food)
        {
            if (!PreferredFoodTypes.Contains(food.GetType().Name))
            {
                //string animalType = this.GetType().Name;
                //string foodType = food.GetType().Name;
                //writer.WriteLine(animalType);
                //writer.WriteLine(foodType);
                //writer.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightModifier;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
