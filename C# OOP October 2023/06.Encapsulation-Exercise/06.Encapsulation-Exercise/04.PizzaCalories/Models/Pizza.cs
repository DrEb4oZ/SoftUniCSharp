using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private const string InvallidPizzaNameException = "Pizza name should be between 1 and 15 symbols.";
        private const string InvallidToppingCountException = "Number of toppings should be in range [0..10].";
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException(InvallidPizzaNameException);
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get=> dough;
            set => dough = value;
        }

        public double Calories
        {
            get => Dough.Calories + toppings.Sum(t => t.Calories);
        }

        public void AddTopping(Topping topping)
        {
            if(toppings.Count == 10)
            {
                throw new ArgumentException(InvallidToppingCountException);
            }
            toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {Calories:f2} Calories.";
        }
    }
}
