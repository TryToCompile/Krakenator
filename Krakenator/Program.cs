using static System.Console;


Creature NPC = new Creature();
NPC.Name = "NPC";
NPC.PrintStatus();

Creature Adam = new Player();
Adam.Name = "Adam";
Adam.PrintStatus();


Player Niko = new Player();
Niko.Name = "Niko";
Niko.PrintStatus();
Niko.Attack();
class Creature
{
    private string _name;
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
    public double HP { get; set; }
    
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

    public void Attack()
    {
        WriteLine("ATTAAACK!");
    }
}

sealed class Admin
{

}