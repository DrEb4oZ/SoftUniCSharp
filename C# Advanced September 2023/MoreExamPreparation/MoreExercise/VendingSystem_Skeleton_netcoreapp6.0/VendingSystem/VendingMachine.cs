﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }
        public int ButtonCapacity { get; set; }

        public List<Drink> Drinks { get; set; }

        public int GetCount { get  {return Drinks.Count; } private set { } }

        public void AddDrink(Drink drink)
        {
            if (Drinks.Count < ButtonCapacity)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name) => Drinks.Remove(Drinks.FirstOrDefault(x => x.Name == name));

        public Drink GetLongest() => Drinks.MaxBy(d => d.Volume);

        public Drink GetCheapest() => Drinks.MinBy(d => d.Price);

        public string BuyDrink(string name) => Drinks.FirstOrDefault(d => d.Name == name).ToString();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            foreach (Drink drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
