using System;

abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }
    protected abstract void Step1();
    protected abstract void Step2();
    protected abstract void Step3();
}