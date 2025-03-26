using System;

class Program
{
    static void Main()
    {
        AbstractClass objA = new ConcreteClassA();
        objA.TemplateMethod();

        Console.WriteLine();

        AbstractClass objB = new ConcreteClassB();
        objB.TemplateMethod();
    }
}