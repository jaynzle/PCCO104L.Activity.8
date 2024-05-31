using System;

internal class Program
{
    static void Main(string[] args)
    {
        Char RickGrimes = new Human(1025, "Rick Grimes", "Revolver", 42, "Leader", true);
        RickGrimes.Intro();

        Char DarylDixon = new Human(987, "Daryl Dixon", "Crossbow", 45, "Hunter", true);
        DarylDixon.Intro();

        Char GlennRhee = new Human(752, "Glenn Rhee", "Butterfly Knife", 25, "Scout", false);
        GlennRhee.Intro();

        Char Walker1 = new Walker(100, "Walker1", "Hands");
        Walker1.Intro();

        Char Walker2 = new Walker(50, "Walker2", "Bite");
        Walker2.Intro();

        Animal dog = new Animal("Dog", 3, "Daryl");
        dog.Intro();
    }
}

public class Char
{
    private string Name { get; set; }
    private string Weapon { get; set; }
    private double Kills { get; set; }

    public int Age { get; set; }
    public string Role { get; set; }
    public bool IsAlive { get; set; }

    public Char()
    {
        Name = "Unknown";
        Weapon = "Unknown";
        Kills = 0;
        Age = 0;
        Role = "Unknown";
        IsAlive = false;
    }

    public Char(double kills, string name, string weapon, int age, string role, bool isAlive)
    {
        Kills = kills;
        Name = name;
        Weapon = weapon;
        Age = age;
        Role = role;
        IsAlive = isAlive;
    }

    public void Intro()
    {
        Console.WriteLine($"{Name} - {Weapon} - {Kills} kills. Age: {Age}, Role: {Role}, Alive: {IsAlive}");
    }
}

internal class Human : Char
{
    public Human(double kills, string name, string weapon, int age, string role, bool isAlive)
        : base(kills, name, weapon, age, role, isAlive)
    {
    }
}

internal class Walker : Char
{
    public Walker(double kills, string name, string weapon)
        : base(kills, name, weapon, 0, "Undead", true)
    {
    }
}

public interface ILivingBeing
{
    void Intro();
}

public class Animal : ILivingBeing
{
    private string Species { get; set; }
    private int Age { get; set; }
    private string Companion { get; set; }

    public Animal(string species, int age, string companion)
    {
        Species = species;
        Age = age;
        Companion = companion;
    }

    public void Intro()
    {
        Console.WriteLine($"A {Species} which is {Age} years old is a companion of {Companion}.");
    }
}