using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const double DefaultDoughCaloriesPerGram = 2;
        private const string InvallidDoughTypeException = "Invalid type of dough.";
        private const string InvallidDoughWeightException = "Dough weight should be in the range [1..200].";
        private const double DoughMinWeight = 1;
        private const double DoughMaxWeight = 200;
        private Dictionary<string, double> flourTypesCalories;
        private Dictionary<string, double> techniquesCalories;

        private string flourType;
        private string bakingTechniques;
        private double weight;

        public Dough(string flourType, string bakingTechniques, double weight)
        {
            flourTypesCalories = new Dictionary<string, double> 
            { 
                { "white", 1.5 }, 
                { "wholegrain", 1.0 } 
            };
            techniquesCalories = new Dictionary<string, double> 
            {
                { "crispy", 0.9 },
                { "chewy", 1.1 },
                { "homemade", 1.0 }
            };
            FlourType = flourType;
            BakingTechniques = bakingTechniques;
            Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (!flourTypesCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvallidDoughTypeException);
                }
                flourType = value;
            }
        }

        public string BakingTechniques
        {
            get
            {
                return bakingTechniques;
            }
            private set
            {
                if (!techniquesCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvallidDoughTypeException);
                }
                bakingTechniques = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if(value < DoughMinWeight || value > DoughMaxWeight)
                {
                    throw new ArgumentException(InvallidDoughWeightException);
                }
                weight = value;
            }
        }

        public double Calories
        {
            get
            {
                double flourTypeModifier = flourTypesCalories[FlourType.ToLower()];
                double techniqueTypeModifier = techniquesCalories[BakingTechniques.ToLower()];
                return flourTypeModifier * techniqueTypeModifier * DefaultDoughCaloriesPerGram * Weight;
            }
        }
    }
}
