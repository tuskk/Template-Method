using System;

class KorpsOfKriegAI : GameAI
{
    protected override void CollectResources()
    {
        Console.WriteLine("Korps Of Krieg don’t collect resources.");
    }
    
    protected override void BuildStructures()
    {
        Console.WriteLine("Korps Of Krieg don’t build structures.");
    }
    
    protected override void BuildUnits()
    {
        Console.WriteLine("Korps Of Krieg don’t build units.");
    }
    
    protected override void SendScouts(string position)
    {
        Console.WriteLine($"Korps Of Krieg send scouts to {position}");
    }
    
    protected override void SendWarriors(string position)
    {
        Console.WriteLine($"Korps Of Krieg send warriors to {position}");
    }
}