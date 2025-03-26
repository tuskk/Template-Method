using System;

abstract class GameAI
{
    public void Turn()
    {
        CollectResources();
        BuildStructures();
        BuildUnits();
        Attack();
    }
    
    protected virtual void CollectResources()
    {
        Console.WriteLine("Collecting resources...");
    }
    
    protected abstract void BuildStructures();
    protected abstract void BuildUnits();
    
    protected void Attack()
    {
        Console.WriteLine("Attacking enemy!");
        var enemy = ClosestEnemy();
        if (enemy == null)
            SendScouts("Center");
        else
            SendWarriors(enemy);
    }
    
    protected abstract void SendScouts(string position);
    protected abstract void SendWarriors(string position);
    
    private string ClosestEnemy() => "EnemyBase"; 
}