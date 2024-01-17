using Raiding.Factory.Interface;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private const string InvalidHeroClassType = "Invalid hero!";

        public IBaseHero Create(string name, string heroClass)
        {
            switch (heroClass)
            {
                case "Druid":
                    return new Druid(name);
                case "Paladin":
                    return new Paladin(name);
                case "Rogue":
                    return new Rogue(name);
                case "Warrior":
                    return new Warrior(name);
                default:
                    throw new ArgumentException(InvalidHeroClassType);
            }
        }
    }
}
