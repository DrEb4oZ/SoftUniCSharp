using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const string CatSound = "Meow";
        private const double CatWeightModifier = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightModifier => CatWeightModifier;

        protected override IReadOnlyCollection<string> PreferredFoodTypes
            => new List<string> { "Vegetable", "Meat" };

        public override string ProduceSound() => CatSound;

    }
}
