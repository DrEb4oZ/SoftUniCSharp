using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double MouseWeightModifier = 0.10;
        private const string MouseSound = "Squeak";

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightModifier => MouseWeightModifier;

        protected override IReadOnlyCollection<string> PreferredFoodTypes
            => new List<string> { "Vegetable", "Fruit" };

        public override string ProduceSound() => MouseSound;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Weight}, {LivingRegion}, {FoodEaten}]");
            return base.ToString() + sb.ToString().TrimEnd();
        }
    }
}
