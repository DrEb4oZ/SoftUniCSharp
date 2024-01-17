using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factory.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factory
{
    public class FoodFactory : IFoodFactory
    {
        public IFood Create(string[] foodTokens)
        {
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);
            switch (foodType)
            {
                case "Fruit":
                    return new Fruit(foodQuantity);
                case "Vegetable":
                    return new Vegetable(foodQuantity);
                case "Seeds":
                    return new Seeds(foodQuantity);
                case "Meat":
                    return new Meat(foodQuantity);
                default:
                    return default;
            }
        }
    }
}
