using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Models
{
    public class Person
    {

        private const string InvallidNameException = "Name cannot be empty";
        private const string InvallidMoneyException = "Money cannot be negative";
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
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

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvallidMoneyException);
                }
                money = value;
            }
        }

        private List<Product> Products
        {
            get => products;
        }

        public void ProductPurchace(string personName, string productName, List<Person> persons, List<Product> products)
        {

            Person inputPerson = persons.FirstOrDefault(p => p.Name == personName);
            Product inputProduct = products.FirstOrDefault(p => p.Name == productName);
            if (inputPerson.Money >= inputProduct.Cost)
            {
                inputPerson.Products.Add(inputProduct);
                inputPerson.Money -= inputProduct.Cost;
                Console.WriteLine($"{personName} bought {productName}");

            }
            else
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
        }

        public override string ToString()
        {
            if (products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", products.Select(p => p.Name))}";

            }
        }
    }
}
