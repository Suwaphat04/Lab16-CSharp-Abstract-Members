using System;

class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Dog();
        animals[1] = new Fish();
        animals[2] = new Bird();

        foreach (var animal in animals)
        {
            animal.Move();
        }
    }
}

abstract class Animal
{
    public abstract void Move();
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: running on the ground");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: swimming in water");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: flying in the air");
    }
}
