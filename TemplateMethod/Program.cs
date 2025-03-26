using System;

class Program
{
    static void Main()
    {
        GameAI orcs = new BoizAI();
        orcs.Turn();

        Console.WriteLine();

        GameAI monsters = new KorpsOfKriegAI();
        monsters.Turn();
    }
}