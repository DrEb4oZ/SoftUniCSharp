using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private const string InvallidToppingTypeException = "Cannot place {0} on top of your pizza.";
        private const string InvallidToppingWeightException = "{0} weight should be in the range [1..50].";
        private const double ToppingMinWeight = 1;
        private const double ToppingMaxWeight = 50;
        private Dictionary<string, double> toppingsCalories;
        private double weight;
        private string toppingType;

        public Topping(string toppingType, double weight)
        {
            toppingsCalories = new Dictionary<string, double>
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                { "sauce", 0.9 }
            };
            ToppingType = toppingType;
            Weight = weight;
        }

        public string ToppingType
        {
            get => toppingType;
            private set
            {
                if (!toppingsCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(string.Format(InvallidToppingTypeException, value));
                }
                toppingType = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if(value < ToppingMinWeight || value > ToppingMaxWeight)
                {
                    throw new ArgumentException(string.Format(InvallidToppingWeightException, this.toppingType));
                }
                weight = value;
            }
        }

        public double Calories
        {
            get
            {
                double toppingTypeModifeier = toppingsCalories[ToppingType.ToLower()];
                return toppingTypeModifeier * BaseCaloriesPerGram * Weight;
            }
        }
    }
}
