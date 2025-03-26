using System;

class ConcreteClassB : AbstractClass
{
    protected override void Step1() => Console.WriteLine("ConcreteClassB: Step1");
    protected override void Step2() => Console.WriteLine("ConcreteClassB: Step2");
    protected override void Step3() => Console.WriteLine("ConcreteClassB: Step3");
}