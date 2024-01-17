using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const string DogSound = "Woof!";
        private const double DogWeightModifier = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightModifier => DogWeightModifier;

        protected override IReadOnlyCollection<string> PreferredFoodTypes
            => new List<string> { "Meat" };

        public override string ProduceSound() => DogSound;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Weight}, {LivingRegion}, {FoodEaten}]");
            return base.ToString() + sb.ToString().TrimEnd();
        }

    }
}
