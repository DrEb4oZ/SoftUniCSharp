using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> caloriesPerDay = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int mealsCount = 0;
            while (meals.Any() && caloriesPerDay.Any())
            {
                int currentCalories = caloriesPerDay.Pop();

                while (currentCalories > 0 && meals.Any())
                {
                    string meal = meals.Dequeue();
                    mealsCount++;
                    if (meal == "salad")
                    {
                        currentCalories -= 350;

                        if (currentCalories < 0)
                        {
                            if (caloriesPerDay.Any())
                            {
                                int nextMealCalories = caloriesPerDay.Pop();
                                nextMealCalories -= Math.Abs(currentCalories);
                                caloriesPerDay.Push(nextMealCalories);
                                break;
                            }

                            break;
                        }

                        if (currentCalories == 0)
                        {
                            break;
                        }

                    }

                    else if (meal == "soup")
                    {
                        currentCalories -= 490;

                        if (currentCalories < 0)
                        {
                            if (caloriesPerDay.Any())
                            {
                                int nextMealCalories = caloriesPerDay.Pop();
                                nextMealCalories -= Math.Abs(currentCalories);
                                caloriesPerDay.Push(nextMealCalories);
                                break;
                            }

                            break;
                        }

                        if (currentCalories == 0)
                        {
                            break;
                        }
                    }

                    else if (meal == "pasta")
                    {
                        currentCalories -= 680;

                        if (currentCalories < 0)
                        {
                            if (caloriesPerDay.Any())
                            {
                                int nextMealCalories = caloriesPerDay.Pop();
                                nextMealCalories -= Math.Abs(currentCalories);
                                caloriesPerDay.Push(nextMealCalories);
                                break;
                            }

                            break;
                        }

                        if (currentCalories == 0)
                        {
                            break;
                        }
                    }

                    else if (meal == "steak")
                    {
                        currentCalories -= 790;

                        if (currentCalories < 0)
                        {
                            if (caloriesPerDay.Any())
                            {
                                int nextMealCalories = caloriesPerDay.Pop();
                                nextMealCalories -= Math.Abs(currentCalories);
                                caloriesPerDay.Push(nextMealCalories);
                                break;
                            }

                            break;
                        }

                        if (currentCalories == 0)
                        {
                            break;
                        }
                    }

                }
                if (currentCalories > 0)
                {
                    caloriesPerDay.Push(currentCalories);
                }
            }

            if (!meals.Any())
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDay)} calories.");
            }

            else
            {
                Console.WriteLine($"John ate enough, he had {mealsCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}