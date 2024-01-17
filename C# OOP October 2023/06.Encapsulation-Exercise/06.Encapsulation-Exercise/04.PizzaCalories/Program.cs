using PizzaCalories.Models;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaTokens = Console.ReadLine()
                .Split();
            string[] doughTokens = Console.ReadLine()
                .Split();
            try
            {
                Pizza pizza = new Pizza(pizzaTokens[1]);
                Dough dough = new Dough(doughTokens[1], doughTokens[2], double.Parse(doughTokens[3]));
                pizza.Dough = dough;


                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingTokens = command
                        .Split();
                    Topping topping = new Topping(toppingTokens[1], double.Parse(toppingTokens[2]));
                    pizza.AddTopping(topping);

                }
                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
