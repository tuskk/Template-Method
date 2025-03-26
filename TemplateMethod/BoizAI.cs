using System;

class BoizAI : GameAI
{
    protected override void BuildStructures()
    {
        Console.WriteLine("Boiz are building structures...");
    }
    
    protected override void BuildUnits()
    {
        Console.WriteLine("Boiz are training warriors...");
    }
    
    protected override void SendScouts(string position)
    {
        Console.WriteLine($"Boiz send scouts to {position}");
    }
    
    protected override void SendWarriors(string position)
    {
        Console.WriteLine($"Boiz send warriors to {position}");
    }
}