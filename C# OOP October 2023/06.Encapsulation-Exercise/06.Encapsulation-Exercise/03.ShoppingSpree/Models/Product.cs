using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private const string InvallidNameException = "Name cannot be empty";
        private const string InvallidMoneyException = "Money cannot be negative";
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvallidNameException);
                }
                name = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvallidMoneyException);
                }
                cost = value;
            }
        }
    }
}
