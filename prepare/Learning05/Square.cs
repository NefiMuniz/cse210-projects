using System;

public class Square : Shape
{
    // Member variable to store the side length of the square
    private double _side;

    // Constructor to set the color and side length of the square
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea method to compute the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}
