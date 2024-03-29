﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        protected Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{WingSize}, {Weight}, {FoodEaten}]");
            return base.ToString() + sb.ToString().TrimEnd();
        }
    }
}
