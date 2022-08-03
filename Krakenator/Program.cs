using static System.Console;


Creature NPC = new Creature();
NPC.Name = "NPC";
NPC.PrintStatus();

Enemy rat = new Enemy();
rat.Name = "Rat";
rat.PrintStatus();

Player Niko = new Player();
Niko.Name = "Niko";
Niko.PrintStatus();
Niko.Attack(rat);






class Creature
{
    private string _name = "undefined";
    public string Name { 
        get {
            return _name;
        } set {
            if (value.Length > 2 && value.Length < 35)
            {
                _name = value;
            } else
            {
                WriteLine("Error, name length should be more than 2 and less than 35");
            }
        } 
    }
    private double _hp;
    public double HP { get; set; } = 100;
    private double attack;
    public double Attack { get; set; } = 10;
    
    public void PrintStatus()
    {
        Console.WriteLine($"Name:{Name}\n" +
                          $"");
    }
}

class Player : Creature
{
    public new void PrintStatus()
    {
        WriteLine($"I'm Player!");
    }

    public void Attack(Enemy enemy)
    {
        WriteLine("ATTAAACK!");

    }
}

class Enemy : Creature
{
    public new void PrintStatus()
    {
        WriteLine($"I'm Enemy!");
    }

    public void Attack(Player player)
    {
        WriteLine("Attack");
    }
}

sealed class Admin
{

}