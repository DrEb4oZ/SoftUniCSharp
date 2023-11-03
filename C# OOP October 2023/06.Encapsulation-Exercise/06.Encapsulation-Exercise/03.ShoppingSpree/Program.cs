using ShoppingSpree.Models;
using System;
using System.Net.Http.Headers;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personsTokens = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsTokesn = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                List<Person> persons = new List<Person>();
                foreach (string person in personsTokens)
                {
                    string[] personToken = person.Split("=");
                    Person currentPerson = new Person(personToken[0], decimal.Parse(personToken[1]));
                    persons.Add(currentPerson);
                }
                List<Product> products = new List<Product>();
                foreach (string product in productsTokesn)
                {
                    string[] productToken = product.Split("=");
                    Product currentProduct = new Product(productToken[0], decimal.Parse(productToken[1]));
                    products.Add(currentProduct);
                }

                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] commandTokens = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person inputPerson = persons.FirstOrDefault(p => p.Name == personName);
                    inputPerson.ProductPurchace(personName,productName,persons,products);  // this method can be made better
                }

                foreach (Person person in persons)
                {
                    Console.WriteLine(person);
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}