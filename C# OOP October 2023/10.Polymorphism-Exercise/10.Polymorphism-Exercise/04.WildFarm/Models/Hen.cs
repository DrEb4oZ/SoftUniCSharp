using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const string HenSound = "Cluck";
        private const double HenWeightModifier = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightModifier => HenWeightModifier;

        protected override IReadOnlyCollection<string> PreferredFoodTypes
            => new List<string> { "Fruit", "Meat", "Seeds", "Vegetable" };

        public override string ProduceSound() => HenSound;
        
    }
}
