using System;
using HeroesLibrary;
using System.Collections.Generic;

namespace HeroGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf player = ChooseHero();
            Elf enemy = ChooseEnemy();

            Console.WriteLine("\nBattle Begins!");
            player.ShowStats();
            enemy.ShowStats();

            PerformAttack(player, enemy);

            Console.WriteLine("\nBattle Ends!");
            player.ShowStats();
            enemy.ShowStats();

            Console.ReadKey();
        }

        static Elf ChooseHero()
        {
            Console.WriteLine("Choose your hero:");
            Console.WriteLine("1. Elven Knight");
            Console.WriteLine("2. Elven Scout");
            Console.WriteLine("3. Temple Knight");
            Console.WriteLine("4. Swordsinger");
            Console.WriteLine("5. Plainswalker");
            Console.WriteLine("6. Silver Ranger");
            Console.WriteLine("7. Euras Templar");
            Console.WriteLine("8. Sword Muse");
            Console.WriteLine("9. Wind Rider");
            Console.WriteLine("10. Moonlight Sentinel");
            Console.WriteLine("11. Elven Wizard");
            Console.WriteLine("12. Elven Oracle");
            Console.WriteLine("13. Elemental Summoner");
            Console.WriteLine("14. Spellsinger");
            Console.WriteLine("15. Mystic Muse");
            Console.WriteLine("16. Euras Saint");
            Console.WriteLine("17. Elemental Master");

            int choice = GetValidChoice(1, 17);

            Console.Write("Enter your hero's name: ");
            string name = Console.ReadLine();

            return CreateHero(choice, name);
        }

        static Elf ChooseEnemy()
        {
            Console.WriteLine("\nChoose your enemy:");
            Console.WriteLine("1. Elven Knight");
            Console.WriteLine("2. Elven Scout");
            Console.WriteLine("3. Temple Knight");
            Console.WriteLine("4. Swordsinger");
            Console.WriteLine("5. Plainswalker");
            Console.WriteLine("6. Silver Ranger");
            Console.WriteLine("7. Euras Templar");
            Console.WriteLine("8. Sword Muse");
            Console.WriteLine("9. Wind Rider");
            Console.WriteLine("10. Moonlight Sentinel");
            Console.WriteLine("11. Elven Wizard");
            Console.WriteLine("12. Elven Oracle");
            Console.WriteLine("13. Elemental Summoner");
            Console.WriteLine("14. Spellsinger");
            Console.WriteLine("15. Mystic Muse");
            Console.WriteLine("16. Euras Saint");
            Console.WriteLine("17. Elemental Master");

            int choice = GetValidChoice(1, 17);

            Console.Write("Enter your enemy's name: ");
            string name = Console.ReadLine();

            return CreateHero(choice, name);
        }

        static int GetValidChoice(int min, int max)
        {
            int choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
                {
                    return choice;
                }
                Console.WriteLine($"Invalid choice. Please enter a number between {min} and {max}.");
            }
        }

        static Elf CreateHero(int choice, string name)
        {
            switch (choice)
            {
                case 1: return new ElvenKnight(name, 1, 100);
                case 2: return new ElvenScout(name, 1, 80);
                case 3: return new TempleKnight(name, 1, 120);
                case 4: return new Swordsinger(name, 1, 110);
                case 5: return new Plainswalker(name, 1, 90);
                case 6: return new SilverRanger(name, 1, 85);
                case 7: return new EurasTemplar(name, 1, 130);
                case 8: return new SwordMuse(name, 1, 115);
                case 9: return new WindRider(name, 1, 95);
                case 10: return new MoonlightSentinel(name, 1, 90);
                case 11: return new ElvenWizard(name, 1, 70);
                case 12: return new ElvenOracle(name, 1, 75);
                case 13: return new ElementalSummoner(name, 1, 80);
                case 14: return new Spellsinger(name, 1, 78);
                case 15: return new MysticMuse(name, 1, 82);
                case 16: return new EurasSaint(name, 1, 85);
                case 17: return new ElementalMaster(name, 1, 88);
                default: return null;
            }
        }

        static void PerformAttack(Elf attacker, Elf defender)
        {
            Random random = new Random();
            int damage = random.Next(10, 30); // Random damage between 10 and 30

            attacker.Attack();
            Console.WriteLine($"{attacker.Name} deals {damage} damage to {defender.Name}!");

            defender.Health -= damage;
            if (defender.Health < 0)
            {
                defender.Health = 0;
            }
        }
    }
}
