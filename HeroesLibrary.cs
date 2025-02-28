using System;

namespace HeroesLibrary
{
    // Базовий клас для всіх ельфів
    public abstract class Elf
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Elf(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }

        public abstract void Attack();
        public abstract void Defend();
        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}, Health: {Health}");
        }
    }

    // Класи для гілки бійців
    public abstract class ElvenFighter : Elf
    {
        public ElvenFighter(string name, int level, int health) : base(name, level, health) { }
    }

    public class ElvenKnight : ElvenFighter
    {
        public ElvenKnight(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} attacks with a sword!"); }
        public override void Defend() { Console.WriteLine($"{Name} raises his shield!"); }
    }

    public class ElvenScout : ElvenFighter
    {
        public ElvenScout(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} fires an arrow!"); }
        public override void Defend() { Console.WriteLine($"{Name} dodges the attack!"); }
    }

    public class TempleKnight : ElvenKnight
    {
        public TempleKnight(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} unleashes a holy strike!"); }
    }

    public class Swordsinger : ElvenKnight
    {
        public Swordsinger(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} weaves a sword dance!"); }
    }

    public class Plainswalker : ElvenScout
    {
        public Plainswalker(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} summons a beast to attack!"); }
    }

    public class SilverRanger : ElvenScout
    {
        public SilverRanger(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} fires a barrage of arrows!"); }
    }

    public class EurasTemplar : TempleKnight
    {
        public EurasTemplar(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} calls upon divine power to strike!"); }
    }

    public class SwordMuse : Swordsinger
    {
        public SwordMuse(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} uses a song to enhance their swordplay!"); }
    }

    public class WindRider : Plainswalker
    {
        public WindRider(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} commands the winds to attack!"); }
    }

    public class MoonlightSentinel : SilverRanger
    {
        public MoonlightSentinel(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} fires arrows imbued with moonlight!"); }
    }

    // Класи для гілки містиків
    public abstract class ElvenMystic : Elf
    {
        public ElvenMystic(string name, int level, int health) : base(name, level, health) { }
    }

    public class ElvenWizard : ElvenMystic
    {
        public ElvenWizard(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} casts a fireball!"); }
        public override void Defend() { Console.WriteLine($"{Name} creates a magical barrier!"); }
    }

    public class ElvenOracle : ElvenMystic
    {
        public ElvenOracle(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} unleashes a psychic blast!"); }
        public override void Defend() { Console.WriteLine($"{Name} foresees the attack and evades!"); }
    }

    public class ElementalSummoner : ElvenWizard
    {
        public ElementalSummoner(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} summons an elemental to attack!"); }
    }

    public class Spellsinger : ElvenWizard
    {
        public Spellsinger(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} weaves a magical song to attack!"); }
    }

    public class MysticMuse : ElvenOracle
    {
        public MysticMuse(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} uses mental illusions to attack!"); }
    }

    public class EurasSaint : ElvenOracle
    {
        public EurasSaint(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} channels divine energy to attack!"); }
    }

    public class ElementalMaster : ElementalSummoner
    {
        public ElementalMaster(string name, int level, int health) : base(name, level, health) { }
        public override void Attack() { Console.WriteLine($"{Name} commands multiple elementals to attack!"); }
    }

}
