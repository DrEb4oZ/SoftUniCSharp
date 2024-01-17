using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const string OwlSound = "Hoot Hoot";
        private const double OwlWeightModifier = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightModifier => OwlWeightModifier;

        protected override IReadOnlyCollection<string> PreferredFoodTypes
            => new List<string> { "Meat" };

        public override string ProduceSound() => OwlSound;

        
    }
}
