using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Fish : IFish
    {
        private string name;
        private double points;
        private int timeToCatch;

        protected Fish(string name, double points, int timeToCatch)
        {
            Name = name;
            Points = points;
            TimeToCatch = timeToCatch;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.FishNameNull);
                }
                name = value;
            }
        }

        public double Points   // TODO: points must be whole number like 1, 2, 3 or decimal to the first number 1.1, 2.3. so it should be checked and then rounded
        {
            get => points;
            private set
            {
                if(value < 1 || value > 10)
                {
                    throw new ArgumentException(ExceptionMessages.PointsNotInRange);
                }
                //points = value;
                
                if(value % 10 == 0)
                {
                    points = value;
                }
                else
                {
                    points = Math.Round(value, 1);
                }
            }
        }

        public int TimeToCatch
        {
            get => timeToCatch;
            private set
            {
                timeToCatch = value;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name} [ Points: {Points}, Time to Catch: {TimeToCatch} seconds ]";
        }
    }
}
