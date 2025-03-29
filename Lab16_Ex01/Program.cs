using System;

class Program
{
    static void Main()
    {
        BaseClass BC = new DerivedClass();
        BC.A();
    }
}

abstract class BaseClass
{
    public abstract void A();  // กำหนดเป็น abstract method ที่ต้อง override ในคลาสที่สืบทอด
}

class DerivedClass : BaseClass
{
    public override void A()
    {
        Console.WriteLine("Implementation of inheritance classes");
    }
}
