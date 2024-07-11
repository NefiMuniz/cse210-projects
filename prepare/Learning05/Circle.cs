using System;

public class Circle : Shape
{
    // Member variable to store the radius of the circle
    private double _radius;

    // Constructor to set the color and radius of the circle
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to compute the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
