﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models.Interfaces
{
    public interface IBuyer : IName
    {
        public int Food { get; }

        void BuyFood();
    }
}
