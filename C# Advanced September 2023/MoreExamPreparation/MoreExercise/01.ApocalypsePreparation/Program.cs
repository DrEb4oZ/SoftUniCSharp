using System.Diagnostics;
using System.Dynamic;
/*
20 10 40 70 20
50 10 30 20 80

 */
namespace _01.ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> textiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> medicaments = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Dictionary<string, int> createdItems = new Dictionary<string, int>();
            while (textiles.Count != 0 && medicaments.Count != 0)
            {
                int textile = textiles.Dequeue();
                int medicament = medicaments.Pop();
                int result = textile + medicament;

                if (result == 30)
                {
                    if (!createdItems.ContainsKey("Patch"))
                    {
                        createdItems.Add("Patch", 0);
                    }

                    createdItems["Patch"]++;
                }

                else if (result == 40)
                {
                    if (!createdItems.ContainsKey("Bandage"))
                    {
                        createdItems.Add("Bandage", 0);
                    }

                    createdItems["Bandage"]++;
                }

                else if (result == 100)
                {
                    if (!createdItems.ContainsKey("MedKit"))
                    {
                        createdItems.Add("MedKit", 0);
                    }

                    createdItems["MedKit"]++;
                }

                else if (result > 100)
                {
                    if (!createdItems.ContainsKey("MedKit"))
                    {
                        createdItems.Add("MedKit", 0);
                    }

                    createdItems["MedKit"]++;
                    result -= 100;
                    int medicamentIncrease = medicaments.Pop() + result;
                    medicaments.Push(medicamentIncrease);
                }

                else
                {
                    medicament += 10;
                    medicaments.Push(medicament);
                }
            }

            if (textiles.Count == 0 && medicaments.Count > 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            
            else if (textiles.Count > 0 && medicaments.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }

            else
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }

            foreach (KeyValuePair<string,int> item in createdItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            if (medicaments.Count > 0)
            {
                Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
            }

            else if (textiles.Count > 0)
            {
                Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
            }
        }
    }
}