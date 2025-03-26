using System;

class ConcreteClassA : AbstractClass
{
    protected override void Step1() => Console.WriteLine("ConcreteClassA: Step1");
    protected override void Step2() => Console.WriteLine("ConcreteClassA: Step2");
    protected override void Step3() => Console.WriteLine("ConcreteClassA: Step3");
}