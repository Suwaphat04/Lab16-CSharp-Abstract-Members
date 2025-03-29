using System;

class Program
{
    static void Main()
    {
        var shapes = new Shape[3];
        shapes[0] = new Rectangle(10, 20);
        shapes[1] = new Triangle(10, 20);
        shapes[2] = new Circle(10);

        foreach (var shape in shapes)
        {
            shape.CalculateArea();
            shape.Draw();
        }
    }
}

abstract class Shape
{
    protected double Area;
    public abstract void Draw();
    public abstract void CalculateArea();
}

class Rectangle : Shape
{
    private double width, height;

    public Rectangle(double W, double H)
    {
        width = W;
        height = H;
    }

    public override void Draw()
    {
        Console.WriteLine($"Draw a rectangle with area {Area:F5}");
    }

    public override void CalculateArea()
    {
        Area = width * height;
        Console.WriteLine($"{this.GetType().Name} Area = {width:F5} x {height:F5} = {Area:F5} unit(s)");
    }
}

class Triangle : Shape
{
    private double Base, Height;

    public Triangle(double B, double H)
    {
        Base = B;
        Height = H;
    }

    public override void Draw()
    {
        Console.WriteLine($"Draw a triangle with area {Area:F5}");
    }

    public override void CalculateArea()
    {
        Area = Base * Height * 0.5;
        Console.WriteLine($"{this.GetType().Name} Area = {Base:F5} x {Height:F5} x 1/2  = {Area:F5} unit(s)");
    }
}

class Circle : Shape
{
    private double Radius;

    public Circle(double R)
    {
        Radius = R;
    }

    public override void Draw()
    {
        Console.WriteLine($"Draw a circle with area {Area:F5}");
    }

    public override void CalculateArea()
    {
        Area = Math.PI * Radius * Radius;
        Console.WriteLine($"{this.GetType().Name} Area = {Math.PI:F5} x {Radius}^2  = {Area:F5} unit(s)");
    }
}
