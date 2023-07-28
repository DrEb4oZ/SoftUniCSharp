namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroTokens = Console.ReadLine()
                    .Split();
                string heroName = heroTokens[0];
                uint hP = uint.Parse(heroTokens[1]);
                uint mP = uint.Parse(heroTokens[2]);
                Hero currentHero = new Hero(heroName, hP, mP);
                heroes.Add(heroName, currentHero);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandTokens = command
                    .Split(" - ");
                string currentCommand = commandTokens[0];
                string heroName = commandTokens[1];
                switch (currentCommand)
                {
                    case "CastSpell":
                        uint mPNeeded = uint.Parse(commandTokens[2]);
                        string spellName = commandTokens[3];
                        CastSpell(heroes, heroName, mPNeeded, spellName);
                        break;
                    case "TakeDamage":
                        uint damageTaken = uint.Parse(commandTokens[2]);
                        string attacker = commandTokens[3];
                        MonsterEncounter(heroes, heroName, damageTaken, attacker);
                        break;
                    case "Recharge":
                        uint mPRechargeAmount = uint.Parse(commandTokens[2]);
                        RechargeMP(heroes, heroName, mPRechargeAmount);
                        break;
                    case "Heal":
                        uint hPHealAmount = uint.Parse(commandTokens[2]);
                        Heal(heroes, heroName, hPHealAmount);
                        break;
                }
            }

            foreach (Hero hero in heroes.Values)
            {
                Console.WriteLine($"{hero.Name}\r\n  HP: {hero.HP}\r\n  MP: {hero.MP}");
            }
        }

        private static void Heal(Dictionary<string, Hero> heroes, string heroName, uint hPHealAmount)
        {
            uint tempHP = heroes[heroName].HP + hPHealAmount;
            uint healedAmount = 0;
            if (tempHP > 100)
            {
                healedAmount = 100 - heroes[heroName].HP;
                heroes[heroName].HP = 100;
            }

            else
            {
                heroes[heroName].HP = tempHP;
                healedAmount = hPHealAmount;
            }

            Console.WriteLine($"{heroes[heroName].Name} healed for {healedAmount} HP!");
        }

        private static void RechargeMP(Dictionary<string, Hero> heroes, string heroName, uint mPRechargeAmount)
        {
            uint tempMP = heroes[heroName].MP + mPRechargeAmount;
            uint rechargedAmount = 0;
            if (tempMP > 200)
            {
                rechargedAmount = 200 - heroes[heroName].MP;
                heroes[heroName].MP = 200;
            }

            else
            {
                heroes[heroName].MP = tempMP;
                rechargedAmount = mPRechargeAmount;
            }

            Console.WriteLine($"{heroes[heroName].Name} recharged for {rechargedAmount} MP!");
        }

        private static void MonsterEncounter(Dictionary<string, Hero> heroes, string heroName, uint damageTaken, string attacker)
        {
            if (damageTaken < heroes[heroName].HP)
            {
                heroes[heroName].HP -= damageTaken;
                Console.WriteLine($"{heroes[heroName].Name} was hit for {damageTaken} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
            }

            else
            {
                Console.WriteLine($"{heroes[heroName].Name} has been killed by {attacker}!");
                heroes.Remove(heroName);
            }
        }

        private static void CastSpell(Dictionary<string, Hero> heroes, string heroName, uint mPNeeded, string spellName)
        {
            if (mPNeeded <= heroes[heroName].MP)
            {
                heroes[heroName].MP -= mPNeeded;
                Console.WriteLine($"{heroes[heroName].Name} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
            }

            else
            {
                Console.WriteLine($"{heroes[heroName].Name} does not have enough MP to cast {spellName}!");
            }
        }
    }
    public class Hero
    {
        public Hero(string name, uint hP, uint mP)
        {
            Name = name;
            HP = hP;
            MP = mP;
        }

        public string Name { get; set; }
        public uint HP { get; set; }
        public uint MP { get; set; }
    }
}