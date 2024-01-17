using Raiding.Core.Interfaces;
using Raiding.Factory.Interface;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IHeroFactory heroFactory;
        private ICollection<IBaseHero> heroes;
        public Engine(IReader reader, IWriter writer, IHeroFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;
            heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int heroCount = int.Parse(reader.ReadLine());

            while (heroes.Count != heroCount)
            {
                CreateHero(heroes);
            }

            int bossPower = int.Parse(reader.ReadLine());
            foreach (var hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
            }
            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }

        private void CreateHero(ICollection<IBaseHero> heroes)
        {
            try
            {
                string name = reader.ReadLine();
                string heroClass = reader.ReadLine();
                heroes.Add(heroFactory.Create(name, heroClass));
                //writer.WriteLine(heroes.FirstOrDefault(h => h.Name == name).CastAbility()); // if there are two heroes with the same name it will give false information but still judge doesn`t catch it. it gives false output because it expects all the heroCast after each other and if there is an error it will pop up in between, so the correct way is to print them with foreach after the last input
                //IBaseHero hero = heroFactory.Create(name, heroClass);
                //writer.WriteLine(hero.CastAbility());
                //heroes.Add(hero);
            }
            catch (ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
        }
    }
}
