using System;

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Rectangle();
        shapes[1] = new Triangle();
        shapes[2] = new Circle();

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}

abstract class Shape
{
    public abstract void Draw();
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a rectangle");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a triangle");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}
