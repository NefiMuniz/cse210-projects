using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5.0)); // Test square
        shapes.Add(new Rectangle("Blue", 4.0, 6.0)); // Test rectangle
        shapes.Add(new Circle("Green", 3.0)); // Test Circle

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
